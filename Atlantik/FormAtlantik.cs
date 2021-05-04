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
    public partial class FormAtlantik : Form
    {
        //%zfk!23F 
        private static MySqlConnection mySqlConnection = new MySqlConnection("Server=localhost;Database=atlantik;port=3306;User Id=root;password=");

        private Dictionary<ToolStripMenuItem, Form> dictionary_ToolStripMenuItem_Form = new Dictionary<ToolStripMenuItem, Form>();

        public FormAtlantik()
        {
            InitializeComponent();
            InitializeConnectionMySQL();
            InitializeDictionaryToolStripMenuItemForm();
        }

        private void InitializeDictionaryToolStripMenuItemForm()
        {
            dictionary_ToolStripMenuItem_Form.Add(secteurAddToolStripMenuItem, new FormAjouterUnSecteur(mySqlConnection));
            dictionary_ToolStripMenuItem_Form.Add(portAddToolStripMenuItem, new FormAjouterUnPort(mySqlConnection));
            dictionary_ToolStripMenuItem_Form.Add(liaisonAddToolStripMenuItem, new FormAjouterUneLiaison(mySqlConnection));
            dictionary_ToolStripMenuItem_Form.Add(tarifsPourUneLiaisonEtUnePeriodeAddToolStripMenuItem, new FormAjouterLesTarifsPourUneLiaisonEtUnePeriode(mySqlConnection));
            dictionary_ToolStripMenuItem_Form.Add(bateauAddToolStripMenuItem, new FormAjouterUnBateau(mySqlConnection));
            dictionary_ToolStripMenuItem_Form.Add(bateauEditToolStripMenuItem, new FormModifierUnBateau(mySqlConnection));
            dictionary_ToolStripMenuItem_Form.Add(traverseeAddToolStripMenuItem, new FormAjouterUneTraversee(mySqlConnection));
            dictionary_ToolStripMenuItem_Form.Add(traverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesShowParCatégorieToolStripMenuItem, new FormAfficherLesTraverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesParCategorie(mySqlConnection));
            dictionary_ToolStripMenuItem_Form.Add(detailsDuneReservationPourUnClientShowToolStripMenuItem, new FormAfficherLesDetailsDUneReservationPourUnClient(mySqlConnection));
            dictionary_ToolStripMenuItem_Form.Add(parametresDuSiteEditToolStripMenuItem, new FormModifierLesParametresDuSite(mySqlConnection));
        }

        private void InitializeConnectionMySQL()
        {
            try
            {
                mySqlConnection.Open();
                mySqlConnection.Close();
            }
            catch(Exception e)
            {
                DialogResult echecConnexionBDD = MessageBox.Show("Connexion à la base de données : Échec", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (echecConnexionBDD.Equals(DialogResult.OK))
                {
                    System.Environment.Exit(0);
                }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form;
            dictionary_ToolStripMenuItem_Form.TryGetValue((ToolStripMenuItem)sender, out form);
            if(form != null) form.ShowDialog();
            
        }

        public static MySqlConnection GetMySqlConnection()
        {
            return mySqlConnection;
        }
    }
}
