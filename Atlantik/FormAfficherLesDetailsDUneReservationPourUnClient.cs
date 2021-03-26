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
    public partial class FormAfficherLesDetailsDUneReservationPourUnClient : Form
    {
        private MySqlConnection mySqlConnection;
        private List<Label> labelList = new List<Label>();

        public FormAfficherLesDetailsDUneReservationPourUnClient(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            this.mySqlConnection = mySqlConnection;

        }

        private void FormAfficherLesDetailsDUneReservationPourUnClient_Load(object sender, EventArgs e)
        {
            SQLClient.InitializeComboBoxAllSQLClient(comboBoxClient, mySqlConnection);
        }

        private void ComboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewReservation.Items.Clear();
            foreach (SQLReservation sqlReservation in SQLReservation.GetAllSQLReservationByNoclient(mySqlConnection, ((SQLClient)((ComboBox)sender).SelectedItem).GetNoclient()))
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { sqlReservation.GetNoreservation().ToString(), 
                    SQLLiaison.GetSQLLiaisonBySQLReservation(mySqlConnection, sqlReservation).ToString(), 
                    sqlReservation.GetNotraversee().ToString(), sqlReservation.GetDateTimeWithSpecificFormat()});


                listViewReservation.Items.Add(listViewItem);
            }
        }

        private void ListViewReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Label label1 in labelList)
            {
                groupBoxReservation.Controls.Remove(label1);
            }
            labelList.Clear();
            
            int i = 0;
            int noreservation = int.Parse(listViewReservation.SelectedItems[0].SubItems[0].Text);
            foreach (SQLEnregistrer sqlEnregistrer in SQLEnregistrer.GetAllSQLEnregistrerByNoreservation(mySqlConnection, noreservation))
            {
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Location = new System.Drawing.Point(5, 20 + 25 * i);
                label1.Name = "label" + sqlEnregistrer.GetLibelleType();
                label1.Size = new System.Drawing.Size(100, 15);
                label1.TabIndex = 0;
                label1.Text = sqlEnregistrer.GetLibelleType() + " : " + sqlEnregistrer.GetQuantite().ToString();
                groupBoxReservation.Controls.Add(label1);
                labelList.Add(label1);
                i++;
            }

            SQLReservation sqlReservation = SQLReservation.GetSQLReservationByNoreservation(mySqlConnection, noreservation);
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(5, 20 + 25 * i);
            label.Name = "labelMontant";
            label.Size = new System.Drawing.Size(100, 15);
            label.TabIndex = 0;
            label.Text = "Montant total : " + sqlReservation.GetMontanttotal().ToString();
            groupBoxReservation.Controls.Add(label);
            labelList.Add(label);
            i++; 

            label = new Label();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(5, 20 + 25 * i);
            label.Name = "labelTypeReglement";
            label.Size = new System.Drawing.Size(100, 15);
            label.TabIndex = 0;
            label.Text = "Type de règlement : "+sqlReservation.GetModedereglement();
            groupBoxReservation.Controls.Add(label);
            labelList.Add(label);
        }
    }
}
