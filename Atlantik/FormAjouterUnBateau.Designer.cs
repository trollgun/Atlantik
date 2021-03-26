
namespace Atlantik
{
    partial class FormAjouterUnBateau
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
            this.groupBoxCapacitesMaximalesParType = new System.Windows.Forms.GroupBox();
            this.textBoxBateau = new System.Windows.Forms.TextBox();
            this.labelBateau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(15, 120);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(100, 23);
            this.buttonAjouter.TabIndex = 7;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // groupBoxCapacitesMaximalesParType
            // 
            this.groupBoxCapacitesMaximalesParType.BackColor = System.Drawing.Color.White;
            this.groupBoxCapacitesMaximalesParType.Location = new System.Drawing.Point(135, 24);
            this.groupBoxCapacitesMaximalesParType.Name = "groupBoxCapacitesMaximalesParType";
            this.groupBoxCapacitesMaximalesParType.Size = new System.Drawing.Size(267, 119);
            this.groupBoxCapacitesMaximalesParType.TabIndex = 6;
            this.groupBoxCapacitesMaximalesParType.TabStop = false;
            this.groupBoxCapacitesMaximalesParType.Text = "Capacités Maximales";
            // 
            // textBoxBateau
            // 
            this.textBoxBateau.Location = new System.Drawing.Point(15, 40);
            this.textBoxBateau.Name = "textBoxBateau";
            this.textBoxBateau.Size = new System.Drawing.Size(100, 20);
            this.textBoxBateau.TabIndex = 5;
            // 
            // labelBateau
            // 
            this.labelBateau.AutoSize = true;
            this.labelBateau.Location = new System.Drawing.Point(12, 24);
            this.labelBateau.Name = "labelBateau";
            this.labelBateau.Size = new System.Drawing.Size(71, 13);
            this.labelBateau.TabIndex = 4;
            this.labelBateau.Text = "Nom bateau :";
            // 
            // FormAjouterUnBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(414, 187);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.groupBoxCapacitesMaximalesParType);
            this.Controls.Add(this.textBoxBateau);
            this.Controls.Add(this.labelBateau);
            this.Name = "FormAjouterUnBateau";
            this.Text = "Ajouter un bateau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.GroupBox groupBoxCapacitesMaximalesParType;
        private System.Windows.Forms.TextBox textBoxBateau;
        private System.Windows.Forms.Label labelBateau;
    }
}