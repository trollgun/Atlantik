
namespace Atlantik
{
    partial class FormAfficherLesTraverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesParCategorie
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
            this.labelLiaison = new System.Windows.Forms.Label();
            this.comboBoxLiaison = new System.Windows.Forms.ComboBox();
            this.labelSecteur = new System.Windows.Forms.Label();
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDateTraversee = new System.Windows.Forms.DateTimePicker();
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.listViewInfo = new System.Windows.Forms.ListView();
            this.columnHeaderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHeure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBateau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelLiaison
            // 
            this.labelLiaison.AutoSize = true;
            this.labelLiaison.Location = new System.Drawing.Point(215, 11);
            this.labelLiaison.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLiaison.Name = "labelLiaison";
            this.labelLiaison.Size = new System.Drawing.Size(61, 17);
            this.labelLiaison.TabIndex = 20;
            this.labelLiaison.Text = "Liaison :";
            // 
            // comboBoxLiaison
            // 
            this.comboBoxLiaison.FormattingEnabled = true;
            this.comboBoxLiaison.Location = new System.Drawing.Point(215, 33);
            this.comboBoxLiaison.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLiaison.Name = "comboBoxLiaison";
            this.comboBoxLiaison.Size = new System.Drawing.Size(160, 24);
            this.comboBoxLiaison.TabIndex = 19;
            // 
            // labelSecteur
            // 
            this.labelSecteur.AutoSize = true;
            this.labelSecteur.Location = new System.Drawing.Point(16, 11);
            this.labelSecteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecteur.Name = "labelSecteur";
            this.labelSecteur.Size = new System.Drawing.Size(72, 17);
            this.labelSecteur.TabIndex = 18;
            this.labelSecteur.Text = "Secteurs :";
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.ItemHeight = 16;
            this.listBoxSecteur.Location = new System.Drawing.Point(20, 31);
            this.listBoxSecteur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(159, 276);
            this.listBoxSecteur.TabIndex = 17;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.ListBoxSecteur_SelectedIndexChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(455, 11);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 17);
            this.labelDate.TabIndex = 28;
            this.labelDate.Text = "Date :";
            // 
            // dateTimePickerDateTraversee
            // 
            this.dateTimePickerDateTraversee.CustomFormat = "hh:mm - dd/MM/yyyy";
            this.dateTimePickerDateTraversee.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateTraversee.Location = new System.Drawing.Point(459, 33);
            this.dateTimePickerDateTraversee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDateTraversee.Name = "dateTimePickerDateTraversee";
            this.dateTimePickerDateTraversee.Size = new System.Drawing.Size(160, 22);
            this.dateTimePickerDateTraversee.TabIndex = 27;
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Location = new System.Drawing.Point(704, 33);
            this.buttonAfficher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(131, 28);
            this.buttonAfficher.TabIndex = 29;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.ButtonAfficher_Click);
            // 
            // listViewInfo
            // 
            this.listViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNo,
            this.columnHeaderHeure,
            this.columnHeaderBateau});
            this.listViewInfo.FullRowSelect = true;
            this.listViewInfo.GridLines = true;
            this.listViewInfo.HideSelection = false;
            this.listViewInfo.Location = new System.Drawing.Point(215, 84);
            this.listViewInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewInfo.Name = "listViewInfo";
            this.listViewInfo.Size = new System.Drawing.Size(619, 223);
            this.listViewInfo.TabIndex = 30;
            this.listViewInfo.UseCompatibleStateImageBehavior = false;
            this.listViewInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNo
            // 
            this.columnHeaderNo.Text = "N°";
            this.columnHeaderNo.Width = 40;
            // 
            // columnHeaderHeure
            // 
            this.columnHeaderHeure.Text = "Heure";
            // 
            // columnHeaderBateau
            // 
            this.columnHeaderBateau.Text = "Bateau";
            // 
            // FormAfficherLesTraverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesParCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 389);
            this.Controls.Add(this.listViewInfo);
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerDateTraversee);
            this.Controls.Add(this.labelLiaison);
            this.Controls.Add(this.comboBoxLiaison);
            this.Controls.Add(this.labelSecteur);
            this.Controls.Add(this.listBoxSecteur);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAfficherLesTraverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesParCateg" +
    "orie";
            this.Load += new System.EventHandler(this.FormAfficherLesTraverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesParCategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLiaison;
        private System.Windows.Forms.ComboBox comboBoxLiaison;
        private System.Windows.Forms.Label labelSecteur;
        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTraversee;
        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.ListView listViewInfo;
        private System.Windows.Forms.ColumnHeader columnHeaderNo;
        private System.Windows.Forms.ColumnHeader columnHeaderHeure;
        private System.Windows.Forms.ColumnHeader columnHeaderBateau;
    }
}