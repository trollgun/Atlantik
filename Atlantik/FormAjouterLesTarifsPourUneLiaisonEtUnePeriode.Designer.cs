
namespace Atlantik
{
    partial class FormAjouterLesTarifsPourUneLiaisonEtUnePeriode
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
            this.labelPeriodeTarif = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.comboBoxPeriode = new System.Windows.Forms.ComboBox();
            this.labelLiaison = new System.Windows.Forms.Label();
            this.comboBoxLiaison = new System.Windows.Forms.ComboBox();
            this.labelSecteur = new System.Windows.Forms.Label();
            this.groupBoxTarifParCategorie = new System.Windows.Forms.GroupBox();
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelPeriodeTarif
            // 
            this.labelPeriodeTarif.AutoSize = true;
            this.labelPeriodeTarif.Location = new System.Drawing.Point(9, 262);
            this.labelPeriodeTarif.Name = "labelPeriodeTarif";
            this.labelPeriodeTarif.Size = new System.Drawing.Size(49, 13);
            this.labelPeriodeTarif.TabIndex = 19;
            this.labelPeriodeTarif.Text = "Periode :";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(288, 277);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(140, 21);
            this.buttonAjouter.TabIndex = 18;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // comboBoxPeriode
            // 
            this.comboBoxPeriode.FormattingEnabled = true;
            this.comboBoxPeriode.Location = new System.Drawing.Point(12, 278);
            this.comboBoxPeriode.Name = "comboBoxPeriode";
            this.comboBoxPeriode.Size = new System.Drawing.Size(241, 21);
            this.comboBoxPeriode.TabIndex = 17;
            // 
            // labelLiaison
            // 
            this.labelLiaison.AutoSize = true;
            this.labelLiaison.Location = new System.Drawing.Point(9, 206);
            this.labelLiaison.Name = "labelLiaison";
            this.labelLiaison.Size = new System.Drawing.Size(46, 13);
            this.labelLiaison.TabIndex = 16;
            this.labelLiaison.Text = "Liaison :";
            // 
            // comboBoxLiaison
            // 
            this.comboBoxLiaison.FormattingEnabled = true;
            this.comboBoxLiaison.Location = new System.Drawing.Point(12, 222);
            this.comboBoxLiaison.Name = "comboBoxLiaison";
            this.comboBoxLiaison.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLiaison.TabIndex = 15;
            // 
            // labelSecteur
            // 
            this.labelSecteur.AutoSize = true;
            this.labelSecteur.Location = new System.Drawing.Point(9, 12);
            this.labelSecteur.Name = "labelSecteur";
            this.labelSecteur.Size = new System.Drawing.Size(55, 13);
            this.labelSecteur.TabIndex = 14;
            this.labelSecteur.Text = "Secteurs :";
            // 
            // groupBoxTarifParCategorie
            // 
            this.groupBoxTarifParCategorie.BackColor = System.Drawing.Color.White;
            this.groupBoxTarifParCategorie.Location = new System.Drawing.Point(174, 12);
            this.groupBoxTarifParCategorie.Name = "groupBoxTarifParCategorie";
            this.groupBoxTarifParCategorie.Size = new System.Drawing.Size(254, 242);
            this.groupBoxTarifParCategorie.TabIndex = 13;
            this.groupBoxTarifParCategorie.TabStop = false;
            this.groupBoxTarifParCategorie.Text = "Tarifs par Catégorie-Type";
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.Location = new System.Drawing.Point(12, 28);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(120, 147);
            this.listBoxSecteur.TabIndex = 12;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.ListBoxSecteur_SelectedIndexChanged);
            // 
            // FormAjouterLesTarifsPourUneLiaisonEtUnePeriode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 306);
            this.Controls.Add(this.labelPeriodeTarif);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.comboBoxPeriode);
            this.Controls.Add(this.labelLiaison);
            this.Controls.Add(this.comboBoxLiaison);
            this.Controls.Add(this.labelSecteur);
            this.Controls.Add(this.groupBoxTarifParCategorie);
            this.Controls.Add(this.listBoxSecteur);
            this.Name = "FormAjouterLesTarifsPourUneLiaisonEtUnePeriode";
            this.Text = "Ajouter les tarifs pour une liaison et une période";
            this.Load += new System.EventHandler(this.FormAjouterLesTarifsPourUneLiaisonEtUnePeriode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPeriodeTarif;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.ComboBox comboBoxPeriode;
        private System.Windows.Forms.Label labelLiaison;
        private System.Windows.Forms.ComboBox comboBoxLiaison;
        private System.Windows.Forms.Label labelSecteur;
        private System.Windows.Forms.GroupBox groupBoxTarifParCategorie;
        private System.Windows.Forms.ListBox listBoxSecteur;
    }
}