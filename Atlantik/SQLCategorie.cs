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
    class SQLCategorie
    {

        private char lettrecategorie;
        private string libelle;

        public SQLCategorie(char lettrecategorie, string libelle)
        {
            this.lettrecategorie = lettrecategorie;
            this.libelle = libelle;
        }

        public char GetLettrecategorie()
        {
            return lettrecategorie;
        }

        public string GetLibelle()
        {
            return libelle;
        }

        public override string ToString()
        {
            return lettrecategorie+" - "+libelle;
        }

        public static List<SQLCategorie> GetAllSQLCategorie(MySqlConnection mySqlConnection)
        {
            List<SQLCategorie> listSQLCategorie = new List<SQLCategorie>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From categorie", mySqlConnection);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLCategorie.Add(new SQLCategorie(reader.GetChar(0), reader.GetString(1)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLCategorie;
        }

    }
}
