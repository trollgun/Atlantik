using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Atlantik
{
    class SQLSecteur
    {

        private int nosecteur;
        private string nom;

        public SQLSecteur(int nosecteur, string nom)
        {
            this.nosecteur = nosecteur;
            this.nom = nom;
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

        public static List<SQLSecteur> GetAllSQLSecteur(MySqlConnection mySqlConnection)
        {
            List<SQLSecteur> listSQLSecteur = new List<SQLSecteur>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From secteur", mySqlConnection);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLSecteur.Add(new SQLSecteur(reader.GetInt16(0), reader.GetString(1)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLSecteur;
        }

        public static void InitializeListBoxAllSQLSecteur(ListBox listBoxSecteur, MySqlConnection mySqlConnection)
        {
            listBoxSecteur.Items.Clear();
            foreach (SQLSecteur sqlSecteur in GetAllSQLSecteur(mySqlConnection)) listBoxSecteur.Items.Add(sqlSecteur);            
        }

    }
}
