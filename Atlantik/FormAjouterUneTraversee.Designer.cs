
namespace Atlantik
{
    partial class FormAjouterUneTraversee
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
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.comboBoxLiaison = new System.Windows.Forms.ComboBox();
            this.comboBoxBateau = new System.Windows.Forms.ComboBox();
            this.labelBateauTraversee = new System.Windows.Forms.Label();
            this.dateTimePickerDepartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArriveeDate = new System.Windows.Forms.DateTimePicker();
            this.labelDepart = new System.Windows.Forms.Label();
            this.labelArrivee = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.labelLiaisonTarif = new System.Windows.Forms.Label();
            this.labelSecteur = new System.Windows.Forms.Label();
            this.dateTimePickerDepartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArriveeTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.Location = new System.Drawing.Point(38, 45);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(120, 147);
            this.listBoxSecteur.TabIndex = 13;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.ListBoxSecteur_SelectedIndexChanged);
            // 
            // comboBoxLiaison
            // 
            this.comboBoxLiaison.FormattingEnabled = true;
            this.comboBoxLiaison.Location = new System.Drawing.Point(37, 211);
            this.comboBoxLiaison.Name = "comboBoxLiaison";
            this.comboBoxLiaison.Size = new System.Drawing.Size(155, 21);
            this.comboBoxLiaison.TabIndex = 16;
            // 
            // comboBoxBateau
            // 
            this.comboBoxBateau.FormattingEnabled = true;
            this.comboBoxBateau.Location = new System.Drawing.Point(182, 45);
            this.comboBoxBateau.Name = "comboBoxBateau";
            this.comboBoxBateau.Size = new System.Drawing.Size(164, 21);
            this.comboBoxBateau.TabIndex = 18;
            // 
            // labelBateauTraversee
            // 
            this.labelBateauTraversee.AutoSize = true;
            this.labelBateauTraversee.Location = new System.Drawing.Point(179, 29);
            this.labelBateauTraversee.Name = "labelBateauTraversee";
            this.labelBateauTraversee.Size = new System.Drawing.Size(71, 13);
            this.labelBateauTraversee.TabIndex = 17;
            this.labelBateauTraversee.Text = "Nom bateau :";
            // 
            // dateTimePickerDepartDate
            // 
            this.dateTimePickerDepartDate.CustomFormat = "hh:mm - dd/MM/yyyy";
            this.dateTimePickerDepartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDepartDate.Location = new System.Drawing.Point(182, 110);
            this.dateTimePickerDepartDate.Name = "dateTimePickerDepartDate";
            this.dateTimePickerDepartDate.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerDepartDate.TabIndex = 19;
            // 
            // dateTimePickerArriveeDate
            // 
            this.dateTimePickerArriveeDate.CustomFormat = "hh:mm - dd/MM/yyyy";
            this.dateTimePickerArriveeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerArriveeDate.Location = new System.Drawing.Point(182, 172);
            this.dateTimePickerArriveeDate.Name = "dateTimePickerArriveeDate";
            this.dateTimePickerArriveeDate.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerArriveeDate.TabIndex = 20;
            // 
            // labelDepart
            // 
            this.labelDepart.AutoSize = true;
            this.labelDepart.Location = new System.Drawing.Point(179, 94);
            this.labelDepart.Name = "labelDepart";
            this.labelDepart.Size = new System.Drawing.Size(120, 13);
            this.labelDepart.TabIndex = 21;
            this.labelDepart.Text = "Date et heure de départ";
            // 
            // labelArrivee
            // 
            this.labelArrivee.AutoSize = true;
            this.labelArrivee.Location = new System.Drawing.Point(179, 156);
            this.labelArrivee.Name = "labelArrivee";
            this.labelArrivee.Size = new System.Drawing.Size(134, 13);
            this.labelArrivee.TabIndex = 22;
            this.labelArrivee.Text = "Date et heure de traversée";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(214, 211);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(132, 21);
            this.buttonAjouter.TabIndex = 23;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // labelLiaisonTarif
            // 
            this.labelLiaisonTarif.AutoSize = true;
            this.labelLiaisonTarif.Location = new System.Drawing.Point(34, 195);
            this.labelLiaisonTarif.Name = "labelLiaisonTarif";
            this.labelLiaisonTarif.Size = new System.Drawing.Size(46, 13);
            this.labelLiaisonTarif.TabIndex = 24;
            this.labelLiaisonTarif.Text = "Liaison :";
            // 
            // labelSecteur
            // 
            this.labelSecteur.AutoSize = true;
            this.labelSecteur.Location = new System.Drawing.Point(35, 29);
            this.labelSecteur.Name = "labelSecteur";
            this.labelSecteur.Size = new System.Drawing.Size(55, 13);
            this.labelSecteur.TabIndex = 25;
            this.labelSecteur.Text = "Secteurs :";
            // 
            // dateTimePickerDepartTime
            // 
            this.dateTimePickerDepartTime.CustomFormat = "hh:mm - dd/MM/yyyy";
            this.dateTimePickerDepartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDepartTime.Location = new System.Drawing.Point(267, 110);
            this.dateTimePickerDepartTime.Name = "dateTimePickerDepartTime";
            this.dateTimePickerDepartTime.ShowUpDown = true;
            this.dateTimePickerDepartTime.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerDepartTime.TabIndex = 26;
            // 
            // dateTimePickerArriveeTime
            // 
            this.dateTimePickerArriveeTime.CustomFormat = "hh:mm - dd/MM/yyyy";
            this.dateTimePickerArriveeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerArriveeTime.Location = new System.Drawing.Point(267, 172);
            this.dateTimePickerArriveeTime.Name = "dateTimePickerArriveeTime";
            this.dateTimePickerArriveeTime.ShowUpDown = true;
            this.dateTimePickerArriveeTime.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerArriveeTime.TabIndex = 27;
            // 
            // FormAjouterUneTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 265);
            this.Controls.Add(this.dateTimePickerArriveeTime);
            this.Controls.Add(this.dateTimePickerDepartTime);
            this.Controls.Add(this.labelSecteur);
            this.Controls.Add(this.labelLiaisonTarif);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelArrivee);
            this.Controls.Add(this.labelDepart);
            this.Controls.Add(this.dateTimePickerArriveeDate);
            this.Controls.Add(this.dateTimePickerDepartDate);
            this.Controls.Add(this.comboBoxBateau);
            this.Controls.Add(this.labelBateauTraversee);
            this.Controls.Add(this.comboBoxLiaison);
            this.Controls.Add(this.listBoxSecteur);
            this.Name = "FormAjouterUneTraversee";
            this.Text = "Ajouter une traversée";
            this.Load += new System.EventHandler(this.FormAjouterUneTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.ComboBox comboBoxLiaison;
        private System.Windows.Forms.ComboBox comboBoxBateau;
        private System.Windows.Forms.Label labelBateauTraversee;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerArriveeDate;
        private System.Windows.Forms.Label labelDepart;
        private System.Windows.Forms.Label labelArrivee;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label labelLiaisonTarif;
        private System.Windows.Forms.Label labelSecteur;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerArriveeTime;
    }
}