using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Atlantik
{
    class SQLPeriode
    {

        private int noperiode;
        private DateTime datedebut, datefin;

        public SQLPeriode(int noperiode, DateTime datedebut, DateTime datefin)
        {
            this.noperiode = noperiode;
            this.datedebut = datedebut;
            this.datefin = datefin;
        }

        public int GetNoperiode()
        {
            return noperiode;
        }

        public override string ToString()
        {
            var format = "dd/MM/yyyy";
            return datedebut.ToString(format)+" au "+datefin.ToString(format);
        }

        public static List<SQLPeriode> GetAllSQLPeriode(MySqlConnection mySqlConnection)
        {
            List<SQLPeriode> listSQLPeriode = new List<SQLPeriode>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From periode", mySqlConnection);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLPeriode.Add(new SQLPeriode(reader.GetInt16(0), reader.GetDateTime(1), reader.GetDateTime(2)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLPeriode;
        }

        public static void InitializeComboBoxAllSQLPeriode(ComboBox comboBoxPeriode, MySqlConnection mySqlConnection)
        {
            comboBoxPeriode.Items.Clear();
            foreach (SQLPeriode sqlPeriode in GetAllSQLPeriode(mySqlConnection)) comboBoxPeriode.Items.Add(sqlPeriode);
        }

    }
}
