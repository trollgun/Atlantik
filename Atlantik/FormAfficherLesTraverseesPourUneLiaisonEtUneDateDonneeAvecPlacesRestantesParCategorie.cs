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
    public partial class FormAfficherLesTraverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesParCategorie : Form
    {
        private MySqlConnection mySqlConnection;

        public FormAfficherLesTraverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesParCategorie(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            this.mySqlConnection = mySqlConnection;
            foreach (SQLCategorie sqlCategorie in SQLCategorie.GetAllSQLCategorie(mySqlConnection)) 
            {
                ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = sqlCategorie.ToString();
                columnHeader.Name = "columnHeader" + sqlCategorie.ToString();
                columnHeader.Width = 100;
                listViewInfo.Columns.Add(columnHeader);
            }
        }

        private void ListBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLLiaison.InitializeComboBoxAllSQLLiaisonBySQLPort(comboBoxLiaison, mySqlConnection, (SQLSecteur)((ListBox)sender).SelectedItem);
            if (comboBoxLiaison.Items.Count > 0) comboBoxLiaison.SelectedIndex = 0;
            else comboBoxLiaison.Text = "";
        }

        private void FormAfficherLesTraverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesParCategorie_Load(object sender, EventArgs e)
        {
            SQLSecteur.InitializeListBoxAllSQLSecteur(listBoxSecteur, mySqlConnection);
            dateTimePickerDateTraversee.Value = DateTime.Now;
        }

        private void ButtonAfficher_Click(object sender, EventArgs e)
        {
            if (comboBoxLiaison.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionez une liaison", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT traversee.notraversee, traversee.dateheuredepart, bateau.nom, bateau.nobateau FROM `traversee`, `bateau` " +
                    "WHERE traversee.nobateau = bateau.nobateau and traversee.noliaison = @noLiaison and traversee.dateheuredepart between @date1 " +
                    "and @date2", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@noLiaison", ((SQLLiaison)comboBoxLiaison.SelectedItem).GetNoliaison());
                mySqlCommand.Parameters.AddWithValue("@date1", dateTimePickerDateTraversee.Value.Date.ToString("yyyy-MM-dd 00:00:00"));
                mySqlCommand.Parameters.AddWithValue("@date2", dateTimePickerDateTraversee.Value.Date.ToString("yyyy-MM-dd 23:59:59"));
                mySqlConnection.Open();
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    listViewInfo.Items.Clear();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            MySqlConnection mySqlConnectionBis = new MySqlConnection(mySqlConnection.ConnectionString);
                            mySqlConnectionBis.Open();
                            MySqlCommand mySqlCommand2 = new MySqlCommand("call create_temporary_table_place_restante(@noTraversee,@noBateau);" +
                                "select value from get_place_restante_out; ", mySqlConnectionBis);
                            mySqlCommand2.Parameters.AddWithValue("@noTraversee", reader.GetInt16(0));
                            mySqlCommand2.Parameters.AddWithValue("@noBateau", reader.GetInt16(3));
                            List<string> listItems = new List<string>();
                            listItems.Add(reader.GetInt16(0).ToString());
                            listItems.Add(reader.GetDateTime(1).ToString("hh-mm"));
                            listItems.Add(reader.GetString(2));
                            using (MySqlDataReader reader2 = mySqlCommand2.ExecuteReader())
                            {                             
                                if (reader2.HasRows)
                                {
                                    while (reader2.Read())
                                    {
                                        listItems.Add(reader2.GetInt16(0).ToString());
                                    }
                                }
                            }
                            listViewInfo.Items.Add(new ListViewItem(listItems.ToArray()));
                            mySqlConnectionBis.Close();
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
}
