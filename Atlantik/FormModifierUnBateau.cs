using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Media;

namespace Atlantik
{
    public partial class FormModifierUnBateau : Form
    {
        private MySqlConnection mySqlConnection;
        private Dictionary<TextBox, SQLCategorie> dictionary_TextBox_SQLCategorie = new Dictionary<TextBox, SQLCategorie>();

        public FormModifierUnBateau(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            this.mySqlConnection = mySqlConnection;

            int i = 0;

            foreach (SQLCategorie sqlCategorie in SQLCategorie.GetAllSQLCategorie(mySqlConnection))
            {
                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(145, 15 + 25 * i);
                textBox.Name = "textBox" + sqlCategorie.ToString();
                textBox.Size = new System.Drawing.Size(100, 20);
                textBox.TabIndex = 0;
                textBox.KeyPress += new KeyPressEventHandler(this.TextBoxCapacite_KeyPress);
                dictionary_TextBox_SQLCategorie.Add(textBox, sqlCategorie);

                Label label = new Label();
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(5, 20 + 25 * i);
                label.Name = "label" + sqlCategorie.ToString();
                label.Size = new System.Drawing.Size(100, 15);
                label.TabIndex = 0;
                label.Text = sqlCategorie.ToString() + " :";

                groupBoxCapacitesMaximalesParType.Controls.Add(textBox);
                groupBoxCapacitesMaximalesParType.Controls.Add(label);

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

        private void ComboBoxBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLBateau sqlBateau = (SQLBateau)((ComboBox)sender).SelectedItem;
            foreach (TextBox textBox in dictionary_TextBox_SQLCategorie.Keys)
            {
                dictionary_TextBox_SQLCategorie.TryGetValue(textBox, out SQLCategorie sqlCategorie);
                try
                {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT capacitemax FROM contenir " +
                        "WHERE lettrecategorie = @lettreCategorie AND nobateau = @noBateau", mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@noBateau", sqlBateau.GetNobateau());
                    mySqlCommand.Parameters.AddWithValue("@lettreCategorie", sqlCategorie.GetLettrecategorie());
                    using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                textBox.Text = reader.GetInt16(0).ToString();
                            }
                        }
                    }
                    mySqlConnection.Close();

                }
                finally
                {
                    if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
                }
            }
        }

        private void FormModifierUnBateau_Load(object sender, EventArgs e)
        {
            SQLBateau.InitializeComboBoxAllSQLBateau(comboBoxBateau, mySqlConnection);
        }

        private void ButtonBateau_Click(object sender, EventArgs e)
        {

            if (comboBoxBateau.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionnez un bateau", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SQLBateau sqlBateau = (SQLBateau)comboBoxBateau.SelectedItem;
                foreach (TextBox textBox in dictionary_TextBox_SQLCategorie.Keys)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("UPDATE `contenir` SET `capacitemax`= @capaciteMax " +
                        "WHERE `lettrecategorie` = @lettreCategorie AND `nobateau` = @noBateau", mySqlConnection);

                    dictionary_TextBox_SQLCategorie.TryGetValue(textBox, out SQLCategorie sqlCategorie);
                    mySqlCommand.Parameters.AddWithValue("@noBateau", sqlBateau.GetNobateau());
                    mySqlCommand.Parameters.AddWithValue("@lettreCategorie", sqlCategorie.GetLettrecategorie());
                    mySqlCommand.Parameters.AddWithValue("@capaciteMax", double.Parse(textBox.Text));
                    if (mySqlCommand.ExecuteNonQuery() == 1) message += "Modifcation de la capacité '" + sqlCategorie.ToString() + "' réussi\n";
                    else message += "Modification de la capacité '" + sqlCategorie.ToString() + "' échec\n";

                }

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
