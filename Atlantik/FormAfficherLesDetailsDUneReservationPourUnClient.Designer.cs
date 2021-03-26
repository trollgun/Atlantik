
namespace Atlantik
{
    partial class FormAfficherLesDetailsDUneReservationPourUnClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelNomPrenom = new System.Windows.Forms.Label();
            this.listViewReservation = new System.Windows.Forms.ListView();
            this.columnHeaderNoReservation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLiaison = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNoTraversee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxReservation = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(12, 29);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClient.TabIndex = 0;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClient_SelectedIndexChanged);
            // 
            // labelNomPrenom
            // 
            this.labelNomPrenom.AutoSize = true;
            this.labelNomPrenom.Location = new System.Drawing.Point(9, 13);
            this.labelNomPrenom.Name = "labelNomPrenom";
            this.labelNomPrenom.Size = new System.Drawing.Size(71, 13);
            this.labelNomPrenom.TabIndex = 1;
            this.labelNomPrenom.Text = "Nom, Prenom";
            // 
            // listViewReservation
            // 
            this.listViewReservation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNoReservation,
            this.columnHeaderLiaison,
            this.columnHeaderNoTraversee,
            this.columnHeaderDateDepart});
            this.listViewReservation.FullRowSelect = true;
            this.listViewReservation.GridLines = true;
            this.listViewReservation.HideSelection = false;
            this.listViewReservation.Location = new System.Drawing.Point(176, 29);
            this.listViewReservation.Name = "listViewReservation";
            this.listViewReservation.Size = new System.Drawing.Size(409, 143);
            this.listViewReservation.TabIndex = 2;
            this.listViewReservation.UseCompatibleStateImageBehavior = false;
            this.listViewReservation.View = System.Windows.Forms.View.Details;
            this.listViewReservation.SelectedIndexChanged += new System.EventHandler(this.ListViewReservation_SelectedIndexChanged);
            // 
            // columnHeaderNoReservation
            // 
            this.columnHeaderNoReservation.Text = "n° Réservation";
            this.columnHeaderNoReservation.Width = 85;
            // 
            // columnHeaderLiaison
            // 
            this.columnHeaderLiaison.Text = "Liaison";
            this.columnHeaderLiaison.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLiaison.Width = 102;
            // 
            // columnHeaderNoTraversee
            // 
            this.columnHeaderNoTraversee.Text = "n° Traversée";
            this.columnHeaderNoTraversee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderNoTraversee.Width = 78;
            // 
            // columnHeaderDateDepart
            // 
            this.columnHeaderDateDepart.Text = "Date départ";
            this.columnHeaderDateDepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDateDepart.Width = 131;
            // 
            // groupBoxReservation
            // 
            this.groupBoxReservation.BackColor = System.Drawing.Color.White;
            this.groupBoxReservation.Location = new System.Drawing.Point(176, 205);
            this.groupBoxReservation.Name = "groupBoxReservation";
            this.groupBoxReservation.Size = new System.Drawing.Size(271, 209);
            this.groupBoxReservation.TabIndex = 3;
            this.groupBoxReservation.TabStop = false;
            this.groupBoxReservation.Text = "Réservation";
            // 
            // FormAfficherLesDetailsDUneReservationPourUnClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.groupBoxReservation);
            this.Controls.Add(this.listViewReservation);
            this.Controls.Add(this.labelNomPrenom);
            this.Controls.Add(this.comboBoxClient);
            this.Name = "FormAfficherLesDetailsDUneReservationPourUnClient";
            this.Text = "Afficher les détails d\'une réservation pour un client";
            this.Load += new System.EventHandler(this.FormAfficherLesDetailsDUneReservationPourUnClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelNomPrenom;
        private System.Windows.Forms.ListView listViewReservation;
        private System.Windows.Forms.ColumnHeader columnHeaderNoReservation;
        private System.Windows.Forms.ColumnHeader columnHeaderLiaison;
        private System.Windows.Forms.ColumnHeader columnHeaderNoTraversee;
        private System.Windows.Forms.ColumnHeader columnHeaderDateDepart;
        private System.Windows.Forms.GroupBox groupBoxReservation;
    }
}