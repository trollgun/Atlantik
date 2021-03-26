
namespace Atlantik
{
    partial class FormAtlantik
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripAtlantik = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secteurAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liaisonAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifsPourUneLiaisonEtUnePeriodeAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bateauAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traverseeAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bateauEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametresDuSiteEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesShowParCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsDuneReservationPourUnClientShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAtlantik.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAtlantik
            // 
            this.menuStripAtlantik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStripAtlantik.Location = new System.Drawing.Point(0, 0);
            this.menuStripAtlantik.Name = "menuStripAtlantik";
            this.menuStripAtlantik.Size = new System.Drawing.Size(800, 24);
            this.menuStripAtlantik.TabIndex = 1;
            this.menuStripAtlantik.Text = "Menu Atlantik";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secteurAddToolStripMenuItem,
            this.portAddToolStripMenuItem,
            this.liaisonAddToolStripMenuItem,
            this.tarifsPourUneLiaisonEtUnePeriodeAddToolStripMenuItem,
            this.bateauAddToolStripMenuItem,
            this.traverseeAddToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // secteurAddToolStripMenuItem
            // 
            this.secteurAddToolStripMenuItem.Name = "secteurAddToolStripMenuItem";
            this.secteurAddToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.secteurAddToolStripMenuItem.Text = "Un secteur";
            this.secteurAddToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // portAddToolStripMenuItem
            // 
            this.portAddToolStripMenuItem.Name = "portAddToolStripMenuItem";
            this.portAddToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.portAddToolStripMenuItem.Text = "Un port";
            this.portAddToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // liaisonAddToolStripMenuItem
            // 
            this.liaisonAddToolStripMenuItem.Name = "liaisonAddToolStripMenuItem";
            this.liaisonAddToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.liaisonAddToolStripMenuItem.Text = "Une liaison";
            this.liaisonAddToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // tarifsPourUneLiaisonEtUnePeriodeAddToolStripMenuItem
            // 
            this.tarifsPourUneLiaisonEtUnePeriodeAddToolStripMenuItem.Name = "tarifsPourUneLiaisonEtUnePeriodeAddToolStripMenuItem";
            this.tarifsPourUneLiaisonEtUnePeriodeAddToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.tarifsPourUneLiaisonEtUnePeriodeAddToolStripMenuItem.Text = "Les tarifs pour une liaison et une période";
            this.tarifsPourUneLiaisonEtUnePeriodeAddToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // bateauAddToolStripMenuItem
            // 
            this.bateauAddToolStripMenuItem.Name = "bateauAddToolStripMenuItem";
            this.bateauAddToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.bateauAddToolStripMenuItem.Text = "Un bateau";
            this.bateauAddToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // traverseeAddToolStripMenuItem
            // 
            this.traverseeAddToolStripMenuItem.Name = "traverseeAddToolStripMenuItem";
            this.traverseeAddToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.traverseeAddToolStripMenuItem.Text = "Une traversée";
            this.traverseeAddToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bateauEditToolStripMenuItem,
            this.parametresDuSiteEditToolStripMenuItem});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // bateauEditToolStripMenuItem
            // 
            this.bateauEditToolStripMenuItem.Name = "bateauEditToolStripMenuItem";
            this.bateauEditToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.bateauEditToolStripMenuItem.Text = "Un bateau ";
            this.bateauEditToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // parametresDuSiteEditToolStripMenuItem
            // 
            this.parametresDuSiteEditToolStripMenuItem.Name = "parametresDuSiteEditToolStripMenuItem";
            this.parametresDuSiteEditToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.parametresDuSiteEditToolStripMenuItem.Text = "Les paramètres du site";
            this.parametresDuSiteEditToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesShowParCatégorieToolStripMenuItem,
            this.detailsDuneReservationPourUnClientShowToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // traverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesShowParCatégorieToolStripMenuItem
            // 
            this.traverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesShowParCatégorieToolStripMenuItem.Name = "traverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesShowParCatégorieToolStr" +
    "ipMenuItem";
            this.traverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesShowParCatégorieToolStripMenuItem.Size = new System.Drawing.Size(524, 22);
            this.traverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesShowParCatégorieToolStripMenuItem.Text = "Les traversées pour une liaison et une date donnée avec places restantes par caté" +
    "gorie";
            this.traverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesShowParCatégorieToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // detailsDuneReservationPourUnClientShowToolStripMenuItem
            // 
            this.detailsDuneReservationPourUnClientShowToolStripMenuItem.Name = "detailsDuneReservationPourUnClientShowToolStripMenuItem";
            this.detailsDuneReservationPourUnClientShowToolStripMenuItem.Size = new System.Drawing.Size(524, 22);
            this.detailsDuneReservationPourUnClientShowToolStripMenuItem.Text = "Les détails d\'une réservation pour un client";
            this.detailsDuneReservationPourUnClientShowToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // FormAtlantik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripAtlantik);
            this.Name = "FormAtlantik";
            this.Text = "Atlantik";
            this.menuStripAtlantik.ResumeLayout(false);
            this.menuStripAtlantik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAtlantik;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secteurAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liaisonAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifsPourUneLiaisonEtUnePeriodeAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bateauAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traverseeAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bateauEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametresDuSiteEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traverseesPourUneLiaisonEtUneDateDonneeAvecPlacesRestantesShowParCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsDuneReservationPourUnClientShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
    }
}

