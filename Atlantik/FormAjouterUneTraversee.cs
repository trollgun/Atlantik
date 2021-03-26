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
    public partial class FormAjouterUneTraversee : Form
    {
        
        private MySqlConnection mySqlConnection;

        public FormAjouterUneTraversee(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            this.mySqlConnection = mySqlConnection;
        }

        private void FormAjouterUneTraversee_Load(object sender, EventArgs e)
        {
            SQLSecteur.InitializeListBoxAllSQLSecteur(listBoxSecteur, mySqlConnection);
            SQLBateau.InitializeComboBoxAllSQLBateau(comboBoxBateau, mySqlConnection);

            dateTimePickerDepartDate.MinDate = DateTime.Now;
            dateTimePickerArriveeDate.MinDate = DateTime.Now;

            dateTimePickerDepartTime.MinDate = DateTime.Now;
            dateTimePickerArriveeTime.MinDate = DateTime.Now;
        }

        private void ListBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLLiaison.InitializeComboBoxAllSQLLiaisonBySQLPort(comboBoxLiaison, mySqlConnection, (SQLSecteur)((ListBox)sender).SelectedItem);
            if (comboBoxLiaison.Items.Count > 0) comboBoxLiaison.SelectedIndex = 0;
            else comboBoxLiaison.Text = "";
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            if (comboBoxLiaison.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionez une liaison", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxBateau.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionez un bateau", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTimePickerDepartDate.Value.Date + dateTimePickerDepartTime.Value.TimeOfDay > dateTimePickerArriveeDate.Value.Date + dateTimePickerArriveeTime.Value.TimeOfDay)
            {
                MessageBox.Show("La date de départ de traversée ne peut être supèrieur a la date d'arrivée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string message = "";
                message += "Ajout de la traversée '" + ((SQLLiaison)comboBoxLiaison.SelectedItem).ToString() + "'\n";
                message += "Bateau '" + ((SQLBateau)comboBoxBateau.SelectedItem).ToString() + "'\n";
                message += "Heure de traversée '" + (dateTimePickerDepartDate.Value.Date + dateTimePickerDepartTime.Value.TimeOfDay).ToString() + "'\n";
                message += "Heure de traversée '" + (dateTimePickerArriveeDate.Value.Date + dateTimePickerArriveeTime.Value.TimeOfDay).ToString() + "'\n";
                

                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `traversee`(`noliaison`, `nobateau`, `dateheuredepart`, `dateheurearrivee`)" +
                    " VALUES (@noLiaison, @noBateau, @dateHeureDepart, @dateHeureArrivee)", mySqlConnection);

                mySqlCommand.Parameters.AddWithValue("@noLiaison", ((SQLLiaison)comboBoxLiaison.SelectedItem).GetNoliaison());
                mySqlCommand.Parameters.AddWithValue("@noBateau", ((SQLBateau)comboBoxBateau.SelectedItem).GetNobateau());
                mySqlCommand.Parameters.AddWithValue("@dateHeureDepart", dateTimePickerDepartDate.Value.Date + dateTimePickerDepartTime.Value.TimeOfDay);
                mySqlCommand.Parameters.AddWithValue("@dateHeureArrivee", dateTimePickerArriveeDate.Value.Date + dateTimePickerArriveeTime.Value.TimeOfDay);
                mySqlConnection.Open();
                if (mySqlCommand.ExecuteNonQuery() == 1) message += "réussi\n";
                else message += "échec\n";
                mySqlConnection.Close();

                
                MessageBox.Show(message);

            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }

        }
    }
}
