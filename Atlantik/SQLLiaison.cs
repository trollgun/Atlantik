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
    class SQLLiaison
    {

        public int noliaison, noport_depart, noport_arrivee;
        public double distance;

        private MySqlConnection mySqlConnection;

        public SQLLiaison(int noliaison, int noport_depart, int noport_arrivee, double distance)
        {
            this.noliaison = noliaison;
            this.noport_depart = noport_depart;
            this.noport_arrivee = noport_arrivee;
            this.distance = distance;
            mySqlConnection = FormAtlantik.GetMySqlConnection();
        }

        public int GetNoliaison()
        {
            return noliaison;
        }

        public int GetNoport_depart()
        {
            return noport_depart;
        }

        public int GetNoport_arrivee()
        {
            return noport_arrivee;
        }
        public double GetDistance()
        {
            return distance;
        }

        public override string ToString()
        {
            return SQLPort.GetNomByNoport(mySqlConnection, noport_depart)+"-"+SQLPort.GetNomByNoport(mySqlConnection, noport_arrivee);
        }

        public static List<SQLLiaison> GetAllSQLLiaison(MySqlConnection mySqlConnection)
        {
            List<SQLLiaison> listSQLLiaison = new List<SQLLiaison>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From liaison", mySqlConnection);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLLiaison.Add(new SQLLiaison(reader.GetInt16(0), reader.GetInt16(1), reader.GetInt16(2), reader.GetDouble(3)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLLiaison;
        }

        public static List<SQLLiaison> GetAllSQLLiaisonBySQLPort(MySqlConnection mySqlConnection, SQLSecteur sqlSecteur)
        {
            List<SQLLiaison> listSQLLiaison = new List<SQLLiaison>();
            
            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `liaison` WHERE `noport_depart` IN (SELECT noport FROM port WHERE port.nosecteur = @noSecteur)", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@noSecteur", sqlSecteur.GetNosecteur());
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLLiaison.Add(new SQLLiaison(reader.GetInt16(0), reader.GetInt16(1), reader.GetInt16(2), reader.GetDouble(3)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLLiaison;
        }

        public static void InitializeComboBoxAllSQLLiaison(ComboBox comboBoxLiaison, MySqlConnection mySqlConnection)
        {
            comboBoxLiaison.Items.Clear();
            foreach (SQLLiaison sqlLiaison in GetAllSQLLiaison(mySqlConnection)) comboBoxLiaison.Items.Add(sqlLiaison);
        }

        public static void InitializeComboBoxAllSQLLiaisonBySQLPort(ComboBox comboBoxLiaison, MySqlConnection mySqlConnection, SQLSecteur sqlSecteur)
        {
            comboBoxLiaison.Items.Clear();
            foreach (SQLLiaison sqlLiaison in GetAllSQLLiaisonBySQLPort(mySqlConnection, sqlSecteur)) comboBoxLiaison.Items.Add(sqlLiaison);
        }

        public static SQLLiaison GetSQLLiaisonBySQLReservation(MySqlConnection mySqlConnection, SQLReservation sqlReservation)
        {
            SQLLiaison sqlLiaison = null;

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `liaison` WHERE " +
                    "`noliaison` in (SELECT traversee.noliaison from traversee where traversee.notraversee = @noTraversee)", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@noTraversee", sqlReservation.GetNotraversee());
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            sqlLiaison = new SQLLiaison(reader.GetInt16(0), reader.GetInt16(1), reader.GetInt16(2), reader.GetDouble(3));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return sqlLiaison;
        }
    }
}
