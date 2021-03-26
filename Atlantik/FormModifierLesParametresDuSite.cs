using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik
{
    public partial class FormModifierLesParametresDuSite : Form
    {
        private MySqlConnection mySqlConnection;   

        public FormModifierLesParametresDuSite(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            this.mySqlConnection = mySqlConnection;
        }

        private void FormModifierLesParametresDuSite_Load(object sender, EventArgs e)
        {
            SQLParametres sqlParametres = SQLParametres.GetSQLParamtres(mySqlConnection);
            textBoxSite.Text = sqlParametres.GetSite_pb();
            textBoxRang.Text = sqlParametres.GetRang_pb();
            textBoxIdentifiant.Text = sqlParametres.GetIndentifiant_pb();
            textBoxHMAC.Text = sqlParametres.GetClehmac_pb();
            checkBoxProduction.Checked = sqlParametres.IsEnproduction();
            textBoxMel.Text = sqlParametres.GetMelsite();
        }

        private void ButtonModifer_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection.Open();
                string message = "";
                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE `parametres` SET `site_pb`= @sitePb,`rang_pb`= @rangPb,`identifiant_pb`= @idPb," +
                    "`clehmac_pb`= @cleHMACPb,`enproduction`= @enProduction,`melsite`= @melSite WHERE noidentifiant = 0", mySqlConnection);

                mySqlCommand.Parameters.AddWithValue("@sitePb", textBoxSite.Text);
                mySqlCommand.Parameters.AddWithValue("@rangPb", textBoxRang.Text);
                mySqlCommand.Parameters.AddWithValue("@idPb", textBoxIdentifiant.Text);
                mySqlCommand.Parameters.AddWithValue("@cleHMACPb", textBoxHMAC.Text);
                mySqlCommand.Parameters.AddWithValue("@enProduction", checkBoxProduction.Checked);
                mySqlCommand.Parameters.AddWithValue("@melSite", textBoxMel.Text);
                if (mySqlCommand.ExecuteNonQuery() == 1) message += "Modifcation des paramètres : réussi\n";
                else message += "Modifcation des paramètres : échec\n";

                

                MessageBox.Show(message);
                mySqlConnection.Close();

            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }
        }
    }
}
