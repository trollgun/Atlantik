using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Atlantik
{
    class SQLType
    {

        //Guillaume Fontaine 25/03/2021

        private char lettrecategorie;
        private int notype;
        private string libelle;

        public SQLType(char lettrecategorie, int notype, string libelle)
        {
            this.lettrecategorie = lettrecategorie;
            this.notype = notype;
            this.libelle = libelle;
        }

        public char GetLettrecategorie()
        {
            return lettrecategorie;
        }

        public int GetNotype()
        {
            return notype;
        }

        public string GetLibelle()
        {
            return libelle;
        }

        public override string ToString()
        {
            return lettrecategorie+" - "+libelle;
        }

        public static List<SQLType> GetAllSQLType(MySqlConnection mySqlConnection)
        {
            List<SQLType> listSQLType = new List<SQLType>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From type", mySqlConnection);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLType.Add(new SQLType(reader.GetChar(0), reader.GetInt16(1), reader.GetString(2)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLType;
        }

        public static SQLType GetSQLTypeByNotypeAndLettrecategorie(MySqlConnection mySqlConnection, int notype, char lettrecategorie)
        {
            SQLType sqlType = null;

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From type where notype = @noType and lettrecategorie = @lettreCategorie", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@noType", notype);
                mySqlCommand.Parameters.AddWithValue("@lettreCategorie", lettrecategorie);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            sqlType = new SQLType(reader.GetChar(0), reader.GetInt16(1), reader.GetString(2));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return sqlType;
        }
    }
}
