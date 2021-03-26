
namespace Atlantik
{
    partial class FormAjouterUneLiaison
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
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.labelDistanceLiaison = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.labelSecteurs = new System.Windows.Forms.Label();
            this.labelArriveeLiaison = new System.Windows.Forms.Label();
            this.labelDepartLiaison = new System.Windows.Forms.Label();
            this.comboBoxArrivee = new System.Windows.Forms.ComboBox();
            this.comboBoxDepart = new System.Windows.Forms.ComboBox();
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(205, 215);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(120, 23);
            this.buttonAjouter.TabIndex = 17;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // labelDistanceLiaison
            // 
            this.labelDistanceLiaison.AutoSize = true;
            this.labelDistanceLiaison.Location = new System.Drawing.Point(206, 134);
            this.labelDistanceLiaison.Name = "labelDistanceLiaison";
            this.labelDistanceLiaison.Size = new System.Drawing.Size(61, 13);
            this.labelDistanceLiaison.TabIndex = 16;
            this.labelDistanceLiaison.Text = "Disatance :";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(206, 153);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(120, 20);
            this.textBoxDistance.TabIndex = 15;
            this.textBoxDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDistance_KeyPress);
            // 
            // labelSecteurs
            // 
            this.labelSecteurs.AutoSize = true;
            this.labelSecteurs.Location = new System.Drawing.Point(26, 23);
            this.labelSecteurs.Name = "labelSecteurs";
            this.labelSecteurs.Size = new System.Drawing.Size(55, 13);
            this.labelSecteurs.TabIndex = 14;
            this.labelSecteurs.Text = "Secteurs :";
            // 
            // labelArriveeLiaison
            // 
            this.labelArriveeLiaison.AutoSize = true;
            this.labelArriveeLiaison.Location = new System.Drawing.Point(206, 77);
            this.labelArriveeLiaison.Name = "labelArriveeLiaison";
            this.labelArriveeLiaison.Size = new System.Drawing.Size(46, 13);
            this.labelArriveeLiaison.TabIndex = 13;
            this.labelArriveeLiaison.Text = "Arrivée :";
            // 
            // labelDepartLiaison
            // 
            this.labelDepartLiaison.AutoSize = true;
            this.labelDepartLiaison.Location = new System.Drawing.Point(203, 23);
            this.labelDepartLiaison.Name = "labelDepartLiaison";
            this.labelDepartLiaison.Size = new System.Drawing.Size(45, 13);
            this.labelDepartLiaison.TabIndex = 12;
            this.labelDepartLiaison.Text = "Départ :";
            // 
            // comboBoxArrivee
            // 
            this.comboBoxArrivee.FormattingEnabled = true;
            this.comboBoxArrivee.Location = new System.Drawing.Point(206, 96);
            this.comboBoxArrivee.Name = "comboBoxArrivee";
            this.comboBoxArrivee.Size = new System.Drawing.Size(120, 21);
            this.comboBoxArrivee.TabIndex = 11;
            // 
            // comboBoxDepart
            // 
            this.comboBoxDepart.FormattingEnabled = true;
            this.comboBoxDepart.Location = new System.Drawing.Point(206, 39);
            this.comboBoxDepart.Name = "comboBoxDepart";
            this.comboBoxDepart.Size = new System.Drawing.Size(120, 21);
            this.comboBoxDepart.TabIndex = 10;
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.Location = new System.Drawing.Point(29, 39);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(120, 199);
            this.listBoxSecteur.TabIndex = 9;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.ListBoxSecteur_SelectedIndexChanged);
            // 
            // FormAjouterUneLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 272);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelDistanceLiaison);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.labelSecteurs);
            this.Controls.Add(this.labelArriveeLiaison);
            this.Controls.Add(this.labelDepartLiaison);
            this.Controls.Add(this.comboBoxArrivee);
            this.Controls.Add(this.comboBoxDepart);
            this.Controls.Add(this.listBoxSecteur);
            this.Name = "FormAjouterUneLiaison";
            this.Text = "Ajouter une liaison";
            this.Load += new System.EventHandler(this.FormAjouterUneLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label labelDistanceLiaison;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label labelSecteurs;
        private System.Windows.Forms.Label labelArriveeLiaison;
        private System.Windows.Forms.Label labelDepartLiaison;
        private System.Windows.Forms.ComboBox comboBoxArrivee;
        private System.Windows.Forms.ComboBox comboBoxDepart;
        private System.Windows.Forms.ListBox listBoxSecteur;
    }
}