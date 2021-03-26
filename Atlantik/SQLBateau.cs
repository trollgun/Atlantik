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
    class SQLBateau
    {

        private int nobateau;
        private string nom;

        public SQLBateau(int nobateau, string nom)
        {
            this.nobateau = nobateau;
            this.nom = nom;
        }

        public int GetNobateau()
        {
            return nobateau;
        }

        public override string ToString()
        {
            return nom;
        }

        public static List<SQLBateau> GetAllSQLBateau(MySqlConnection mySqlConnection)
        {
            List<SQLBateau> listSQLBateau = new List<SQLBateau>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From bateau", mySqlConnection);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLBateau.Add(new SQLBateau(reader.GetInt16(0), reader.GetString(1)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLBateau;
        }

        public static void InitializeComboBoxAllSQLBateau(ComboBox comboBoxBateau, MySqlConnection mySqlConnection)
        {
            comboBoxBateau.Items.Clear();
            foreach (SQLBateau sqlBateau in GetAllSQLBateau(mySqlConnection)) comboBoxBateau.Items.Add(sqlBateau);
        }

    }
}
