
namespace Atlantik
{
    partial class FormAjouterUnSecteur
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
            this.textBoxSecteur = new System.Windows.Forms.TextBox();
            this.labelSecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(128, 88);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(80, 25);
            this.buttonAjouter.TabIndex = 2;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // textBoxSecteur
            // 
            this.textBoxSecteur.Location = new System.Drawing.Point(154, 52);
            this.textBoxSecteur.Name = "textBoxSecteur";
            this.textBoxSecteur.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecteur.TabIndex = 1;
            // 
            // labelSecteur
            // 
            this.labelSecteur.AutoSize = true;
            this.labelSecteur.Location = new System.Drawing.Point(73, 55);
            this.labelSecteur.Name = "labelSecteur";
            this.labelSecteur.Size = new System.Drawing.Size(75, 13);
            this.labelSecteur.TabIndex = 0;
            this.labelSecteur.Text = "Nom Secteur :";
            // 
            // FormAjouterUnSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(349, 176);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxSecteur);
            this.Controls.Add(this.labelSecteur);
            this.Name = "FormAjouterUnSecteur";
            this.Text = "Ajouter un secteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox textBoxSecteur;
        private System.Windows.Forms.Label labelSecteur;
    }
}