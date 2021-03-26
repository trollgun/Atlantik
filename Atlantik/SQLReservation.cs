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
    class SQLReservation
    {

        private int noreservation, notraversee, noclient;
        private DateTime dateheure;
        private double montanttotal;
        private bool paye;
        private string modedereglement;

        public SQLReservation(int noreservation, int notraversee, int noclient, DateTime dateheure, double montanttotal, bool paye, string modedereglement)
        {
            this.noreservation = noreservation;
            this.notraversee = notraversee;
            this.noclient = noclient;
            this.dateheure = dateheure;
            this.montanttotal = montanttotal;
            this.paye = paye;
            this.modedereglement = modedereglement;
        }

        public int GetNoreservation()
        {
            return noreservation;
        }

        public int GetNotraversee()
        {
            return notraversee;
        }

        public double GetMontanttotal()
        {
            return montanttotal;
        }

        public string GetModedereglement()
        {
            return modedereglement;
        }

        public string GetDateTimeWithSpecificFormat()
        {
            return dateheure.ToString("dd/MM/yyyy à hh:mm");
        }

        public override string ToString()
        {
            return noreservation.ToString();
        }

        public static List<SQLReservation> GetAllSQLReservation(MySqlConnection mySqlConnection)
        {
            List<SQLReservation> listSQLReservation = new List<SQLReservation>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From reservation", mySqlConnection);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLReservation.Add(new SQLReservation(reader.GetInt16(0), reader.GetInt16(1), reader.GetInt16(2), reader.GetDateTime(3), reader.GetDouble(4), reader.GetBoolean(5), reader.GetString(6)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLReservation;
        }

        public static List<SQLReservation> GetAllSQLReservationByNoclient(MySqlConnection mySqlConnection, int noclient)
        {
            List<SQLReservation> listSQLReservation = new List<SQLReservation>();

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("Select * From reservation where noclient = @noClient", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@noClient", noclient);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listSQLReservation.Add(new SQLReservation(reader.GetInt16(0), reader.GetInt16(1), reader.GetInt16(2), reader.GetDateTime(3), reader.GetDouble(4), reader.GetBoolean(5), reader.GetString(6)));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return listSQLReservation;
        }

        public static SQLReservation GetSQLReservationByNoreservation(MySqlConnection mySqlConnection, int noreservation)
        {
            SQLReservation sqlReservation = null;

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `reservation` WHERE reservation.noreservation = @noReservation", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@noReservation", noreservation);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            sqlReservation = new SQLReservation(reader.GetInt16(0), reader.GetInt16(1), reader.GetInt16(2), reader.GetDateTime(3), reader.GetDouble(4), reader.GetBoolean(5), reader.GetString(6));
                        }
                    }
                }
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

            return sqlReservation;
        }

    }
}
