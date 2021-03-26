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
    class SQLClient
    {

        private int noclient, codepostal;
        private string nom, prenom, adresse, ville, telephonefixe, telephonemobile, mel;

        public SQLClient(int noclient, string nom, string prenom, string adresse, int codepostal, string ville, string telephonefixe, string telephonemobile, string mel)
        {
            this.noclient = noclient;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.codepostal = codepostal;
            this.ville = ville;
            this.telephonefixe = telephonefixe;
            this.telephonemobile = telephonemobile;
            this.mel = mel;
        }

        public int GetNoclient()
        {
            return noclient;
        }

        public override string ToString()
        {
            return nom+", "+prenom;
        }

        public static List<SQLClient> GetAllSQLClient(MySqlConnection mySqlConnection)
        {
            List<SQLClient> listSQLClient = new List<SQLClient>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From client", mySqlConnection);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLClient.Add(new SQLClient(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt16(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLClient;
        }

        public static void InitializeComboBoxAllSQLClient(ComboBox comboBoxClient, MySqlConnection mySqlConnection)
        {
            comboBoxClient.Items.Clear();
            foreach (SQLClient sqlClient in GetAllSQLClient(mySqlConnection)) comboBoxClient.Items.Add(sqlClient);
        }

    }
}
