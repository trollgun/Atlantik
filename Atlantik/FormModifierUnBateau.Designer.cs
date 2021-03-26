
namespace Atlantik
{
    partial class FormModifierUnBateau
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
            this.comboBoxBateau = new System.Windows.Forms.ComboBox();
            this.buttonBateau = new System.Windows.Forms.Button();
            this.groupBoxCapacitesMaximalesParType = new System.Windows.Forms.GroupBox();
            this.labelBateau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxBateau
            // 
            this.comboBoxBateau.FormattingEnabled = true;
            this.comboBoxBateau.Location = new System.Drawing.Point(15, 40);
            this.comboBoxBateau.Name = "comboBoxBateau";
            this.comboBoxBateau.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBateau.TabIndex = 8;
            this.comboBoxBateau.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBateau_SelectedIndexChanged);
            // 
            // buttonBateau
            // 
            this.buttonBateau.Location = new System.Drawing.Point(15, 120);
            this.buttonBateau.Name = "buttonBateau";
            this.buttonBateau.Size = new System.Drawing.Size(100, 23);
            this.buttonBateau.TabIndex = 7;
            this.buttonBateau.Text = "Modifier\r\n";
            this.buttonBateau.UseVisualStyleBackColor = true;
            this.buttonBateau.Click += new System.EventHandler(this.ButtonBateau_Click);
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
            // labelBateau
            // 
            this.labelBateau.AutoSize = true;
            this.labelBateau.Location = new System.Drawing.Point(12, 24);
            this.labelBateau.Name = "labelBateau";
            this.labelBateau.Size = new System.Drawing.Size(71, 13);
            this.labelBateau.TabIndex = 5;
            this.labelBateau.Text = "Nom bateau :";
            // 
            // FormModifierUnBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(414, 187);
            this.Controls.Add(this.comboBoxBateau);
            this.Controls.Add(this.buttonBateau);
            this.Controls.Add(this.groupBoxCapacitesMaximalesParType);
            this.Controls.Add(this.labelBateau);
            this.Name = "FormModifierUnBateau";
            this.Text = "Modifier un bateau";
            this.Load += new System.EventHandler(this.FormModifierUnBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBateau;
        private System.Windows.Forms.Button buttonBateau;
        private System.Windows.Forms.GroupBox groupBoxCapacitesMaximalesParType;
        private System.Windows.Forms.Label labelBateau;
    }
}