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

namespace Atlantik
{
    public partial class FormAjouterUnSecteur : Form
    {

        private MySqlConnection mySqlConnection;

        public FormAjouterUnSecteur(MySqlConnection mySqlConnection)
        {
            this.mySqlConnection = mySqlConnection;
            InitializeComponent();
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSecteur.Text))
            {
                MessageBox.Show("Le nom de secteur ne peut être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `secteur`(`nom`) VALUES (@nomSecteur)", mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@nomSecteur", textBoxSecteur.Text);
            if (mySqlCommand.ExecuteNonQuery() == 1) MessageBox.Show("Ajout du secteur '" + textBoxSecteur.Text + "' réussie", "Action réussie", MessageBoxButtons.OK);
            else MessageBox.Show("Ajout du secteur '" + textBoxSecteur.Text + "' échec", "Échec", MessageBoxButtons.OK);
            mySqlConnection.Close();
        }
    }
}
