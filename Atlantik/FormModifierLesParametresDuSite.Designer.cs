
namespace Atlantik
{
    partial class FormModifierLesParametresDuSite
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
            this.groupBoxPaybox = new System.Windows.Forms.GroupBox();
            this.labelSite = new System.Windows.Forms.Label();
            this.labelRang = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelHMAC = new System.Windows.Forms.Label();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.textBoxRang = new System.Windows.Forms.TextBox();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxHMAC = new System.Windows.Forms.TextBox();
            this.checkBoxProduction = new System.Windows.Forms.CheckBox();
            this.textBoxMel = new System.Windows.Forms.TextBox();
            this.labelMel = new System.Windows.Forms.Label();
            this.buttonModifer = new System.Windows.Forms.Button();
            this.groupBoxPaybox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPaybox
            // 
            this.groupBoxPaybox.BackColor = System.Drawing.Color.White;
            this.groupBoxPaybox.Controls.Add(this.textBoxHMAC);
            this.groupBoxPaybox.Controls.Add(this.textBoxIdentifiant);
            this.groupBoxPaybox.Controls.Add(this.textBoxRang);
            this.groupBoxPaybox.Controls.Add(this.textBoxSite);
            this.groupBoxPaybox.Controls.Add(this.labelHMAC);
            this.groupBoxPaybox.Controls.Add(this.labelIdentifiant);
            this.groupBoxPaybox.Controls.Add(this.labelRang);
            this.groupBoxPaybox.Controls.Add(this.labelSite);
            this.groupBoxPaybox.Location = new System.Drawing.Point(26, 12);
            this.groupBoxPaybox.Name = "groupBoxPaybox";
            this.groupBoxPaybox.Size = new System.Drawing.Size(251, 209);
            this.groupBoxPaybox.TabIndex = 0;
            this.groupBoxPaybox.TabStop = false;
            this.groupBoxPaybox.Text = "Identifiant PayBox";
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(29, 46);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(34, 13);
            this.labelSite.TabIndex = 0;
            this.labelSite.Text = "Site : ";
            // 
            // labelRang
            // 
            this.labelRang.AutoSize = true;
            this.labelRang.Location = new System.Drawing.Point(29, 80);
            this.labelRang.Name = "labelRang";
            this.labelRang.Size = new System.Drawing.Size(42, 13);
            this.labelRang.TabIndex = 0;
            this.labelRang.Text = "Rang : ";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(29, 110);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(62, 13);
            this.labelIdentifiant.TabIndex = 0;
            this.labelIdentifiant.Text = "Identifiant : ";
            // 
            // labelHMAC
            // 
            this.labelHMAC.AutoSize = true;
            this.labelHMAC.Location = new System.Drawing.Point(29, 145);
            this.labelHMAC.Name = "labelHMAC";
            this.labelHMAC.Size = new System.Drawing.Size(65, 13);
            this.labelHMAC.TabIndex = 0;
            this.labelHMAC.Text = "Clé HMAC : ";
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(134, 43);
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(100, 20);
            this.textBoxSite.TabIndex = 1;
            // 
            // textBoxRang
            // 
            this.textBoxRang.Location = new System.Drawing.Point(134, 77);
            this.textBoxRang.Name = "textBoxRang";
            this.textBoxRang.Size = new System.Drawing.Size(100, 20);
            this.textBoxRang.TabIndex = 1;
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(134, 107);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdentifiant.TabIndex = 1;
            // 
            // textBoxHMAC
            // 
            this.textBoxHMAC.Location = new System.Drawing.Point(134, 142);
            this.textBoxHMAC.Name = "textBoxHMAC";
            this.textBoxHMAC.Size = new System.Drawing.Size(100, 20);
            this.textBoxHMAC.TabIndex = 1;
            // 
            // checkBoxProduction
            // 
            this.checkBoxProduction.AutoSize = true;
            this.checkBoxProduction.Location = new System.Drawing.Point(37, 260);
            this.checkBoxProduction.Name = "checkBoxProduction";
            this.checkBoxProduction.Size = new System.Drawing.Size(92, 17);
            this.checkBoxProduction.TabIndex = 1;
            this.checkBoxProduction.Text = "En production";
            this.checkBoxProduction.UseVisualStyleBackColor = true;
            // 
            // textBoxMel
            // 
            this.textBoxMel.Location = new System.Drawing.Point(160, 227);
            this.textBoxMel.Name = "textBoxMel";
            this.textBoxMel.Size = new System.Drawing.Size(100, 20);
            this.textBoxMel.TabIndex = 1;
            // 
            // labelMel
            // 
            this.labelMel.AutoSize = true;
            this.labelMel.Location = new System.Drawing.Point(55, 230);
            this.labelMel.Name = "labelMel";
            this.labelMel.Size = new System.Drawing.Size(52, 13);
            this.labelMel.TabIndex = 0;
            this.labelMel.Text = "Mèl site : ";
            // 
            // buttonModifer
            // 
            this.buttonModifer.Location = new System.Drawing.Point(160, 260);
            this.buttonModifer.Name = "buttonModifer";
            this.buttonModifer.Size = new System.Drawing.Size(100, 23);
            this.buttonModifer.TabIndex = 2;
            this.buttonModifer.Text = "Modifier";
            this.buttonModifer.UseVisualStyleBackColor = true;
            this.buttonModifer.Click += new System.EventHandler(this.ButtonModifer_Click);
            // 
            // FormModifierLesParametresDuSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 301);
            this.Controls.Add(this.buttonModifer);
            this.Controls.Add(this.textBoxMel);
            this.Controls.Add(this.checkBoxProduction);
            this.Controls.Add(this.groupBoxPaybox);
            this.Controls.Add(this.labelMel);
            this.Name = "FormModifierLesParametresDuSite";
            this.Text = "Modifier les paramètres du site";
            this.Load += new System.EventHandler(this.FormModifierLesParametresDuSite_Load);
            this.groupBoxPaybox.ResumeLayout(false);
            this.groupBoxPaybox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPaybox;
        private System.Windows.Forms.TextBox textBoxHMAC;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxRang;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.Label labelHMAC;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelRang;
        private System.Windows.Forms.Label labelSite;
        private System.Windows.Forms.CheckBox checkBoxProduction;
        private System.Windows.Forms.TextBox textBoxMel;
        private System.Windows.Forms.Label labelMel;
        private System.Windows.Forms.Button buttonModifer;
    }
}