using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Atlantik
{
    class SQLPort
    {
        private int noport, nosecteur;
        private string nom;
        
        public SQLPort(int noport, int nosecteur, string nom)
        {
            this.noport = noport;
            this.nosecteur = nosecteur;
            this.nom = nom;
        }

        public int GetNoport()
        {
            return noport;
        }

        public int GetNosecteur()
        {
            return nosecteur;
        }

        public string GetNom()
        {
            return nom;
        }

        public override string ToString()
        {
            return nom;
        }

        public static List<SQLPort> GetAllSQLPort(MySqlConnection mySqlConnection)
        {
            List<SQLPort> listSQLPort = new List<SQLPort>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From port", mySqlConnection);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLPort.Add(new SQLPort(reader.GetInt16(0), reader.GetInt16(1), reader.GetString(2)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLPort;
        }

        public static List<SQLPort> GetAllSQLPortBySQLSecteur(MySqlConnection mySqlConnection, SQLSecteur sqlSecteur)
        {
            List<SQLPort> listSQLPort = new List<SQLPort>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From port Where nosecteur = @noSecteur", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@noSecteur", sqlSecteur.GetNosecteur());
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLPort.Add(new SQLPort(reader.GetInt16(0), reader.GetInt16(1), reader.GetString(2)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLPort;
        }
        
        public static string GetNomByNoport(MySqlConnection mySqlConnection, int noport)
        {
            string nomPort = "Erreur";
            Boolean connectionIsOpen = mySqlConnection.State.Equals(ConnectionState.Open);
            try
            {
                if (!connectionIsOpen) mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select nom From port Where noport = @noPort", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@noPort", noport);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nomPort = reader.GetString(0);
                        }
                    }
                }
                if (!connectionIsOpen) mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return nomPort;
        }

        public static void InitializeComboBoxAllSQLPort(ComboBox comboBoxPort, MySqlConnection mySqlConnection)
        {
            comboBoxPort.Items.Clear();
            foreach (SQLPort sqlPort in GetAllSQLPort(mySqlConnection)) comboBoxPort.Items.Add(sqlPort);
        }

        public static void InitializeComboBoxAllSQLPortBySQLSecteur(ComboBox comboBoxPort, MySqlConnection mySqlConnection, SQLSecteur sqlSecteur)
        {
            comboBoxPort.Items.Clear();
            foreach (SQLPort sqlPort in GetAllSQLPortBySQLSecteur(mySqlConnection, sqlSecteur)) comboBoxPort.Items.Add(sqlPort);
        }

    }
}
