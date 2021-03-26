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
    public partial class FormAjouterUnPort : Form
    {
        private MySqlConnection mySqlConnection;      

        public FormAjouterUnPort(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            this.mySqlConnection = mySqlConnection;
        }

        private void FormAjouterUnPort_Load(object sender, EventArgs e)
        {
            SQLSecteur.InitializeListBoxAllSQLSecteur(listBoxSecteur,mySqlConnection);
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            if(listBoxSecteur.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionez un secteur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if(string.IsNullOrWhiteSpace(textBoxPort.Text))
            {
                MessageBox.Show("Le nom de port ne peut être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `port`(`nosecteur`, `nom`) VALUES (@noSecteur, @nomPort)", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@noSecteur", ((SQLSecteur)listBoxSecteur.SelectedItem).GetNosecteur());
                mySqlCommand.Parameters.AddWithValue("@nomPort", textBoxPort.Text);
                if (mySqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Ajout du port '" + textBoxPort.Text + "' réussie", "Action réussie", MessageBoxButtons.OK);
                    textBoxPort.Clear();
                }
                else MessageBox.Show("Ajout du port '" + textBoxPort.Text + "' échec", "Échec", MessageBoxButtons.OK);
                mySqlConnection.Close();
            }
            finally
            {
                if (mySqlConnection.State.Equals(ConnectionState.Open)) mySqlConnection.Close();
            }
        }
    }
}
