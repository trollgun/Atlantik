
namespace Atlantik
{
    partial class FormAjouterUnPort
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
            this.labelSecteurPort = new System.Windows.Forms.Label();
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSecteurPort
            // 
            this.labelSecteurPort.AutoSize = true;
            this.labelSecteurPort.Location = new System.Drawing.Point(24, 16);
            this.labelSecteurPort.Name = "labelSecteurPort";
            this.labelSecteurPort.Size = new System.Drawing.Size(55, 13);
            this.labelSecteurPort.TabIndex = 9;
            this.labelSecteurPort.Text = "Secteurs :";
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.Location = new System.Drawing.Point(27, 32);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(120, 199);
            this.listBoxSecteur.TabIndex = 8;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(172, 206);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(120, 25);
            this.buttonAjouter.TabIndex = 7;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(173, 71);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(119, 20);
            this.textBoxPort.TabIndex = 6;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(169, 55);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(57, 13);
            this.labelPort.TabIndex = 5;
            this.labelPort.Text = "Nom Port :";
            // 
            // FormAjouterUnPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(315, 257);
            this.Controls.Add(this.labelSecteurPort);
            this.Controls.Add(this.listBoxSecteur);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Name = "FormAjouterUnPort";
            this.Text = "Ajouter un port";
            this.Load += new System.EventHandler(this.FormAjouterUnPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSecteurPort;
        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
    }
}