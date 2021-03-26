using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Atlantik
{
    class SQLEnregistrer
    {
        private int noreservation, notype, quantite;
        private char lettrecategorie;

        public SQLEnregistrer(int noreservation, char lettrecategorie, int notype, int quantite)
        {
            this.noreservation = noreservation;
            this.lettrecategorie = lettrecategorie;
            this.notype = notype;
            this.quantite = quantite;
        }

        public int GetQuantite()
        {
            return quantite;
        }

        public string GetLibelleType()
        {
            return SQLType.GetSQLTypeByNotypeAndLettrecategorie(FormAtlantik.GetMySqlConnection(), notype, lettrecategorie).GetLibelle();
        }

        public static List<SQLEnregistrer> GetAllSQLEnregistrerByNoreservation(MySqlConnection mySqlConnection, int noreservation)
        {
            List<SQLEnregistrer> listSQLEnregistrer = new List<SQLEnregistrer>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From enregistrer where noreservation = @noReservation", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@noReservation", noreservation);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLEnregistrer.Add(new SQLEnregistrer(reader.GetInt16(0), reader.GetChar(1), reader.GetInt16(2), reader.GetInt16(3)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLEnregistrer;
        }

    }
}
