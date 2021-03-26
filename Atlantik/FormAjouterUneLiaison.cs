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
using System.Media;

namespace Atlantik
{
    public partial class FormAjouterUneLiaison : Form
    {
        private MySqlConnection mySqlConnection;

        public FormAjouterUneLiaison(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            this.mySqlConnection = mySqlConnection;
        }

        private void FormAjouterUneLiaison_Load(object sender, EventArgs e)
        {
            SQLSecteur.InitializeListBoxAllSQLSecteur(listBoxSecteur, mySqlConnection);
            SQLPort.InitializeComboBoxAllSQLPort(comboBoxArrivee, mySqlConnection);
        }

        private void ListBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLPort.InitializeComboBoxAllSQLPortBySQLSecteur(comboBoxDepart, mySqlConnection, (SQLSecteur)((ListBox)sender).SelectedItem);
            if (comboBoxDepart.Items.Count > 0) comboBoxDepart.SelectedIndex = 0;
            else comboBoxDepart.Text = "";
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            if(comboBoxDepart.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionez un port de départ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxArrivee.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionez un port d'arrivée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDistance.Text))
            {
                MessageBox.Show("Le distance ne peut être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `liaison`(`noport_depart`, `noport_arrivee`, `distance`) " +
                    "VALUES (@noPortDepart, @noPortArrivee, @doubleDistance)", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@noPortDepart", ((SQLPort)comboBoxDepart.SelectedItem).GetNoport());
                mySqlCommand.Parameters.AddWithValue("@noPortArrivee", ((SQLPort)comboBoxArrivee.SelectedItem).GetNoport());
                mySqlCommand.Parameters.AddWithValue("@doubleDistance", double.Parse(textBoxDistance.Text));
                if (mySqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Ajout de la liaison '"+comboBoxDepart.Text+"-"+comboBoxArrivee.Text+"' réussie", "Action réussie", MessageBoxButtons.OK);
                    
                }
                else MessageBox.Show("Ajout de la liaison '"+comboBoxDepart.Text+"-"+comboBoxArrivee.Text +"' échec", "Échec", MessageBoxButtons.OK);
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }
        }

        private void TextBoxDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals(','))
            {                
                e.Handled = true;
                SystemSounds.Exclamation.Play();
            }

            if(e.KeyChar.Equals(',') && (textBoxDistance.TextLength == 0 || textBoxDistance.TextLength > 5) && !textBoxDistance.Text.Contains(","))
            {
                e.Handled = true;
                SystemSounds.Exclamation.Play();
            }          
        }
    }
}
