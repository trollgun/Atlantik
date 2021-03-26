using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Atlantik
{
    class SQLParametres
    {

        private int noidentifiant;
        private string site_pb, rang_pb, identifiant_pb, clehmac_pb, melsite;
        private bool enproduction;

        public SQLParametres(int noidentifiant, string site_pb, string rang_pb, string identifiant_pb, string clehmac_pb, bool enproduction, string melsite)
        {
            this.noidentifiant = noidentifiant;
            this.site_pb = site_pb;
            this.rang_pb = rang_pb;
            this.identifiant_pb = identifiant_pb;
            this.clehmac_pb = clehmac_pb;
            this.enproduction = enproduction;
            this.melsite = melsite;
        }

        public string GetSite_pb()
        {
            return site_pb;
        }

        public string GetRang_pb()
        {
            return rang_pb;
        }

        public string GetIndentifiant_pb()
        {
            return identifiant_pb;
        }

        public string GetClehmac_pb()
        {
            return clehmac_pb;
        }

        public bool IsEnproduction()
        {
            return enproduction;
        }

        public string GetMelsite()
        {
            return melsite;
        }

        public static SQLParametres GetSQLParamtres(MySqlConnection mySqlConnection)
        {
            SQLParametres sqlParametres = null;

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From Parametres where noidentifiant = 0", mySqlConnection);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            sqlParametres = new SQLParametres(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5), reader.GetString(6));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return sqlParametres;
        }

    }
}
