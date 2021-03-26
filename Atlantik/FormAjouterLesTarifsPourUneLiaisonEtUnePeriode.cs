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
    public partial class FormAjouterLesTarifsPourUneLiaisonEtUnePeriode : Form
    {
        private MySqlConnection mySqlConnection;
        private Dictionary<TextBox, SQLType> dictionary_TextBox_SQLType = new Dictionary<TextBox, SQLType>();

        public FormAjouterLesTarifsPourUneLiaisonEtUnePeriode(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            this.mySqlConnection = mySqlConnection;

            int i = 0;

            foreach (SQLType sqlType in SQLType.GetAllSQLType(mySqlConnection))
            {
                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(145, 15 + 25 * i);
                textBox.Name = "textBox" + sqlType.ToString();
                textBox.Size = new System.Drawing.Size(100, 20);
                textBox.TabIndex = 0;
                textBox.KeyPress += new KeyPressEventHandler(this.TextBoxTarif_KeyPress);
                dictionary_TextBox_SQLType.Add(textBox, sqlType);

                Label label = new Label();
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(5, 20 + 25 * i);
                label.Name = "label" + sqlType.ToString();
                label.Size = new System.Drawing.Size(100, 15);
                label.TabIndex = 0;
                label.Text = sqlType.ToString() + " :";

                groupBoxTarifParCategorie.Controls.Add(textBox);
                groupBoxTarifParCategorie.Controls.Add(label);

                i++;
            }
        }

        private void FormAjouterLesTarifsPourUneLiaisonEtUnePeriode_Load(object sender, EventArgs e)
        {
            SQLSecteur.InitializeListBoxAllSQLSecteur(listBoxSecteur, mySqlConnection);
            SQLPeriode.InitializeComboBoxAllSQLPeriode(comboBoxPeriode, mySqlConnection);
        }

        private void ListBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLLiaison.InitializeComboBoxAllSQLLiaisonBySQLPort(comboBoxLiaison, mySqlConnection, (SQLSecteur)((ListBox)sender).SelectedItem);
            if (comboBoxLiaison.Items.Count > 0) comboBoxLiaison.SelectedIndex = 0;
            else comboBoxLiaison.Text = "";
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            if(comboBoxLiaison.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionez une liaison", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxPeriode.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionez une periode", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(TextBox textBox in dictionary_TextBox_SQLType.Keys)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Les tarifs ne peuvent être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                mySqlConnection.Open();
                string message = "";
                foreach (TextBox textBox in dictionary_TextBox_SQLType.Keys)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `tarifer`(`noperiode`, `lettrecategorie`, `notype`, `noliaison`, `tarif`) VALUES " +
                        "(@noPeriode, @lettreCategorie, @noType, @noLiaison, @tarif)", mySqlConnection);

                    dictionary_TextBox_SQLType.TryGetValue(textBox, out SQLType sqlType);
                    mySqlCommand.Parameters.AddWithValue("@noPeriode", ((SQLPeriode)comboBoxPeriode.SelectedItem).GetNoperiode());
                    mySqlCommand.Parameters.AddWithValue("@lettreCategorie", sqlType.GetLettrecategorie());
                    mySqlCommand.Parameters.AddWithValue("@noType", sqlType.GetNotype());
                    mySqlCommand.Parameters.AddWithValue("@noLiaison", ((SQLLiaison)comboBoxLiaison.SelectedItem).GetNoliaison());
                    mySqlCommand.Parameters.AddWithValue("@tarif", double.Parse(textBox.Text));
                    if(mySqlCommand.ExecuteNonQuery() == 1) message += "Ajout du tarif '"+sqlType.ToString()+"' réussi\n";
                    else message += "Ajout du tarif '" + sqlType.ToString() + "' échec\n";

                }
                MessageBox.Show(message);
                mySqlConnection.Close();
                
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }


        }

        private void TextBoxTarif_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals(','))
            {
                e.Handled = true;
                SystemSounds.Exclamation.Play();
            }         
        }
    }
}
