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
    public partial class FormAjouterUnBateau : Form
    {
        private MySqlConnection mySqlConnection;
        private Dictionary<TextBox, SQLCategorie> dictionary_TextBox_SQLCategorie = new Dictionary<TextBox, SQLCategorie>();

        public FormAjouterUnBateau(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            this.mySqlConnection = mySqlConnection;

            int i = 0;

            foreach (SQLCategorie sqlCategorie in SQLCategorie.GetAllSQLCategorie(mySqlConnection))
            {
                TextBox textBoxCategorie = new TextBox();
                textBoxCategorie.Location = new System.Drawing.Point(145, 15 + 25 * i);
                textBoxCategorie.Name = "textBox" + sqlCategorie.ToString();
                textBoxCategorie.Size = new System.Drawing.Size(100, 20);
                textBoxCategorie.TabIndex = 0;
                textBoxCategorie.KeyPress += new KeyPressEventHandler(this.TextBoxCapacite_KeyPress);
                dictionary_TextBox_SQLCategorie.Add(textBoxCategorie, sqlCategorie);

                Label labelCategorie = new Label();
                labelCategorie.AutoSize = true;
                labelCategorie.Location = new System.Drawing.Point(5, 20 + 25 * i);
                labelCategorie.Name = "label" + sqlCategorie.ToString();
                labelCategorie.Size = new System.Drawing.Size(100, 15);
                labelCategorie.TabIndex = 0;
                labelCategorie.Text = sqlCategorie.ToString() + " :";

                groupBoxCapacitesMaximalesParType.Controls.Add(textBoxCategorie);
                groupBoxCapacitesMaximalesParType.Controls.Add(labelCategorie);

                i++;
            }
        }

        private void TextBoxCapacite_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Exclamation.Play();
            }
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBateau.Text))
            {
                MessageBox.Show("Le nom du bateau ne peut être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (TextBox textBox in dictionary_TextBox_SQLCategorie.Keys)
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
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `bateau`(`nom`) VALUES (@nomBateau)", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@nomBateau", textBoxBateau.Text);
                if (mySqlCommand.ExecuteNonQuery() == 1)
                {
                    message += "Ajout du bateau '" + textBoxBateau.Text + "' : réussi\n";
                    mySqlConnection.Close();
                    mySqlConnection.Open();
                    foreach (TextBox textBox in dictionary_TextBox_SQLCategorie.Keys)
                    {
                        mySqlCommand = new MySqlCommand("INSERT INTO `contenir`(`lettrecategorie`, `nobateau`, `capacitemax`) VALUES " +
                            "(@lettreCategorie, @noBateau, @capaciteMax)", mySqlConnection);

                        dictionary_TextBox_SQLCategorie.TryGetValue(textBox, out SQLCategorie sqlCategorie);
                        MessageBox.Show(SQLBateau.GetLastInsertId().ToString());
                        mySqlCommand.Parameters.AddWithValue("@noBateau", SQLBateau.GetLastInsertId());
                        mySqlCommand.Parameters.AddWithValue("@lettreCategorie", sqlCategorie.GetLettrecategorie());
                        mySqlCommand.Parameters.AddWithValue("@capaciteMax", double.Parse(textBox.Text));
                        if (mySqlCommand.ExecuteNonQuery() == 1) message += "Ajout de la capacité '" + sqlCategorie.ToString() + "' réussi\n";
                        else message += "Ajout de la capacité '" + sqlCategorie.ToString() + "' échec\n";

                    }
                }
                else message += "Ajout du bateau '" + textBoxBateau.Text + "' : échec\n";

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
