namespace ZiKnCo_MoteurRechercheDeezer
{
    partial class FrmDemarrage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemarrage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lectureMultimédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recherchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBanniere = new System.Windows.Forms.PictureBox();
            this.picDeezer = new System.Windows.Forms.PictureBox();
            this.lblArtisteRecherche = new System.Windows.Forms.Label();
            this.txtArtisteRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.tbpRadio = new System.Windows.Forms.TabPage();
            this.wbRadio = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tbpArtiste = new System.Windows.Forms.TabPage();
            this.grbArtisteInfos = new System.Windows.Forms.GroupBox();
            this.btnEcouterExtraits = new System.Windows.Forms.Button();
            this.lstArtistes = new System.Windows.Forms.ListBox();
            this.lklDeezerLien = new System.Windows.Forms.LinkLabel();
            this.lblArtisteNom = new System.Windows.Forms.Label();
            this.lblArtisteTrouve = new System.Windows.Forms.Label();
            this.picArtiste = new System.Windows.Forms.PictureBox();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbpDiscographie = new System.Windows.Forms.TabPage();
            this.pnlDisco = new System.Windows.Forms.Panel();
            this.wbDisco = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.lblTitres = new System.Windows.Forms.Label();
            this.lstbTitres = new System.Windows.Forms.ListBox();
            this.lstbAlbums = new System.Windows.Forms.ListBox();
            this.lblAlbums = new System.Windows.Forms.Label();
            this.picDisco = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).BeginInit();
            this.tbpRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wbRadio)).BeginInit();
            this.tbpArtiste.SuspendLayout();
            this.grbArtisteInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).BeginInit();
            this.tbc.SuspendLayout();
            this.tbpDiscographie.SuspendLayout();
            this.pnlDisco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wbDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.recherchesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lectureMultimédiaToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "&Outils";
            // 
            // lectureMultimédiaToolStripMenuItem
            // 
            this.lectureMultimédiaToolStripMenuItem.Name = "lectureMultimédiaToolStripMenuItem";
            this.lectureMultimédiaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lectureMultimédiaToolStripMenuItem.Text = "&Lecture Multimédia";
            // 
            // recherchesToolStripMenuItem
            // 
            this.recherchesToolStripMenuItem.Name = "recherchesToolStripMenuItem";
            this.recherchesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.recherchesToolStripMenuItem.Text = "&Recherches";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aProposToolStripMenuItem.Text = "A &propos...";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // picBanniere
            // 
            this.picBanniere.Image = ((System.Drawing.Image)(resources.GetObject("picBanniere.Image")));
            this.picBanniere.Location = new System.Drawing.Point(12, 37);
            this.picBanniere.Name = "picBanniere";
            this.picBanniere.Size = new System.Drawing.Size(580, 66);
            this.picBanniere.TabIndex = 3;
            this.picBanniere.TabStop = false;
            // 
            // picDeezer
            // 
            this.picDeezer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDeezer.Image = ((System.Drawing.Image)(resources.GetObject("picDeezer.Image")));
            this.picDeezer.Location = new System.Drawing.Point(469, 134);
            this.picDeezer.Name = "picDeezer";
            this.picDeezer.Size = new System.Drawing.Size(123, 49);
            this.picDeezer.TabIndex = 4;
            this.picDeezer.TabStop = false;
            this.picDeezer.Click += new System.EventHandler(this.picDeezer_Click);
            // 
            // lblArtisteRecherche
            // 
            this.lblArtisteRecherche.AutoSize = true;
            this.lblArtisteRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteRecherche.ForeColor = System.Drawing.Color.White;
            this.lblArtisteRecherche.Location = new System.Drawing.Point(23, 134);
            this.lblArtisteRecherche.Name = "lblArtisteRecherche";
            this.lblArtisteRecherche.Size = new System.Drawing.Size(93, 13);
            this.lblArtisteRecherche.TabIndex = 5;
            this.lblArtisteRecherche.Text = "Artiste recherché :";
            // 
            // txtArtisteRecherche
            // 
            this.txtArtisteRecherche.Location = new System.Drawing.Point(132, 133);
            this.txtArtisteRecherche.Name = "txtArtisteRecherche";
            this.txtArtisteRecherche.Size = new System.Drawing.Size(100, 20);
            this.txtArtisteRecherche.TabIndex = 6;
            this.txtArtisteRecherche.TextChanged += new System.EventHandler(this.txtArtisteRecherche_TextChanged);
            this.txtArtisteRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArtisteRecherche_KeyPress);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(247, 133);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(68, 19);
            this.btnRechercher.TabIndex = 7;
            this.btnRechercher.Text = "Go !";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // tbpRadio
            // 
            this.tbpRadio.Controls.Add(this.wbRadio);
            this.tbpRadio.Location = new System.Drawing.Point(4, 22);
            this.tbpRadio.Name = "tbpRadio";
            this.tbpRadio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRadio.Size = new System.Drawing.Size(558, 210);
            this.tbpRadio.TabIndex = 1;
            this.tbpRadio.Text = "Radio Artiste";
            this.tbpRadio.UseVisualStyleBackColor = true;
            // 
            // wbRadio
            // 
            this.wbRadio.AllowExternalDrop = true;
            this.wbRadio.CreationProperties = null;
            this.wbRadio.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbRadio.Location = new System.Drawing.Point(3, 0);
            this.wbRadio.Name = "wbRadio";
            this.wbRadio.Size = new System.Drawing.Size(555, 199);
            this.wbRadio.TabIndex = 1;
            this.wbRadio.ZoomFactor = 1D;
            // 
            // tbpArtiste
            // 
            this.tbpArtiste.Controls.Add(this.grbArtisteInfos);
            this.tbpArtiste.Location = new System.Drawing.Point(4, 22);
            this.tbpArtiste.Name = "tbpArtiste";
            this.tbpArtiste.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArtiste.Size = new System.Drawing.Size(558, 210);
            this.tbpArtiste.TabIndex = 0;
            this.tbpArtiste.Text = "Infos Artiste";
            this.tbpArtiste.UseVisualStyleBackColor = true;
            // 
            // grbArtisteInfos
            // 
            this.grbArtisteInfos.Controls.Add(this.btnEcouterExtraits);
            this.grbArtisteInfos.Controls.Add(this.lstArtistes);
            this.grbArtisteInfos.Controls.Add(this.lklDeezerLien);
            this.grbArtisteInfos.Controls.Add(this.lblArtisteNom);
            this.grbArtisteInfos.Controls.Add(this.lblArtisteTrouve);
            this.grbArtisteInfos.Controls.Add(this.picArtiste);
            this.grbArtisteInfos.Location = new System.Drawing.Point(6, 6);
            this.grbArtisteInfos.Name = "grbArtisteInfos";
            this.grbArtisteInfos.Size = new System.Drawing.Size(546, 187);
            this.grbArtisteInfos.TabIndex = 0;
            this.grbArtisteInfos.TabStop = false;
            this.grbArtisteInfos.Text = "Informations DEEZER";
            this.grbArtisteInfos.Visible = false;
            // 
            // btnEcouterExtraits
            // 
            this.btnEcouterExtraits.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEcouterExtraits.Location = new System.Drawing.Point(9, 161);
            this.btnEcouterExtraits.Name = "btnEcouterExtraits";
            this.btnEcouterExtraits.Size = new System.Drawing.Size(225, 23);
            this.btnEcouterExtraits.TabIndex = 6;
            this.btnEcouterExtraits.Text = "&Ecouter tous les extraits musicaux...";
            this.btnEcouterExtraits.UseVisualStyleBackColor = true;
            this.btnEcouterExtraits.Click += new System.EventHandler(this.btnEcouterExtraits_Click);
            // 
            // lstArtistes
            // 
            this.lstArtistes.FormattingEnabled = true;
            this.lstArtistes.Location = new System.Drawing.Point(9, 35);
            this.lstArtistes.Name = "lstArtistes";
            this.lstArtistes.Size = new System.Drawing.Size(225, 121);
            this.lstArtistes.TabIndex = 5;
            this.lstArtistes.SelectedIndexChanged += new System.EventHandler(this.lstArtistes_SelectedIndexChanged);
            // 
            // lklDeezerLien
            // 
            this.lklDeezerLien.AutoSize = true;
            this.lklDeezerLien.Location = new System.Drawing.Point(275, 171);
            this.lklDeezerLien.Name = "lklDeezerLien";
            this.lklDeezerLien.Size = new System.Drawing.Size(74, 13);
            this.lklDeezerLien.TabIndex = 4;
            this.lklDeezerLien.TabStop = true;
            this.lklDeezerLien.Text = "Lien DEEZER";
            this.lklDeezerLien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklDeezerLien_LinkClicked);
            // 
            // lblArtisteNom
            // 
            this.lblArtisteNom.AutoSize = true;
            this.lblArtisteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteNom.Location = new System.Drawing.Point(268, 7);
            this.lblArtisteNom.Name = "lblArtisteNom";
            this.lblArtisteNom.Size = new System.Drawing.Size(59, 25);
            this.lblArtisteNom.TabIndex = 2;
            this.lblArtisteNom.Text = "Nom";
            // 
            // lblArtisteTrouve
            // 
            this.lblArtisteTrouve.AutoSize = true;
            this.lblArtisteTrouve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteTrouve.Location = new System.Drawing.Point(6, 19);
            this.lblArtisteTrouve.Name = "lblArtisteTrouve";
            this.lblArtisteTrouve.Size = new System.Drawing.Size(103, 13);
            this.lblArtisteTrouve.TabIndex = 1;
            this.lblArtisteTrouve.Text = "Artistes trouvés :";
            // 
            // picArtiste
            // 
            this.picArtiste.InitialImage = ((System.Drawing.Image)(resources.GetObject("picArtiste.InitialImage")));
            this.picArtiste.Location = new System.Drawing.Point(273, 35);
            this.picArtiste.Name = "picArtiste";
            this.picArtiste.Size = new System.Drawing.Size(125, 133);
            this.picArtiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtiste.TabIndex = 0;
            this.picArtiste.TabStop = false;
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tbpArtiste);
            this.tbc.Controls.Add(this.tbpDiscographie);
            this.tbc.Controls.Add(this.tbpRadio);
            this.tbc.Location = new System.Drawing.Point(26, 183);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(566, 236);
            this.tbc.TabIndex = 8;
            this.tbc.SelectedIndexChanged += new System.EventHandler(this.tbc_SelectedIndexChanged);
            // 
            // tbpDiscographie
            // 
            this.tbpDiscographie.Controls.Add(this.pnlDisco);
            this.tbpDiscographie.Location = new System.Drawing.Point(4, 22);
            this.tbpDiscographie.Name = "tbpDiscographie";
            this.tbpDiscographie.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDiscographie.Size = new System.Drawing.Size(558, 210);
            this.tbpDiscographie.TabIndex = 2;
            this.tbpDiscographie.Text = "Discographie";
            this.tbpDiscographie.UseVisualStyleBackColor = true;
            // 
            // pnlDisco
            // 
            this.pnlDisco.Controls.Add(this.wbDisco);
            this.pnlDisco.Controls.Add(this.lblTitres);
            this.pnlDisco.Controls.Add(this.lstbTitres);
            this.pnlDisco.Controls.Add(this.lstbAlbums);
            this.pnlDisco.Controls.Add(this.lblAlbums);
            this.pnlDisco.Controls.Add(this.picDisco);
            this.pnlDisco.Location = new System.Drawing.Point(6, 6);
            this.pnlDisco.Name = "pnlDisco";
            this.pnlDisco.Size = new System.Drawing.Size(546, 198);
            this.pnlDisco.TabIndex = 0;
            // 
            // wbDisco
            // 
            this.wbDisco.AllowExternalDrop = true;
            this.wbDisco.CreationProperties = null;
            this.wbDisco.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbDisco.Location = new System.Drawing.Point(12, 130);
            this.wbDisco.Name = "wbDisco";
            this.wbDisco.Size = new System.Drawing.Size(531, 65);
            this.wbDisco.TabIndex = 5;
            this.wbDisco.ZoomFactor = 1D;
            // 
            // lblTitres
            // 
            this.lblTitres.AutoSize = true;
            this.lblTitres.Location = new System.Drawing.Point(342, 0);
            this.lblTitres.Name = "lblTitres";
            this.lblTitres.Size = new System.Drawing.Size(39, 13);
            this.lblTitres.TabIndex = 4;
            this.lblTitres.Text = "Titres :";
            // 
            // lstbTitres
            // 
            this.lstbTitres.FormattingEnabled = true;
            this.lstbTitres.Location = new System.Drawing.Point(345, 16);
            this.lstbTitres.Name = "lstbTitres";
            this.lstbTitres.Size = new System.Drawing.Size(198, 108);
            this.lstbTitres.TabIndex = 3;
            this.lstbTitres.SelectedIndexChanged += new System.EventHandler(this.lstbTitres_SelectedIndexChanged);
            // 
            // lstbAlbums
            // 
            this.lstbAlbums.FormattingEnabled = true;
            this.lstbAlbums.Location = new System.Drawing.Point(152, 16);
            this.lstbAlbums.Name = "lstbAlbums";
            this.lstbAlbums.Size = new System.Drawing.Size(187, 108);
            this.lstbAlbums.TabIndex = 2;
            this.lstbAlbums.SelectedIndexChanged += new System.EventHandler(this.lstbAlbums_SelectedIndexChanged);
            this.lstbAlbums.DoubleClick += new System.EventHandler(this.lstbAlbums_DoubleClick);
            // 
            // lblAlbums
            // 
            this.lblAlbums.AutoSize = true;
            this.lblAlbums.Location = new System.Drawing.Point(149, 0);
            this.lblAlbums.Name = "lblAlbums";
            this.lblAlbums.Size = new System.Drawing.Size(47, 13);
            this.lblAlbums.TabIndex = 1;
            this.lblAlbums.Text = "Albums :";
            // 
            // picDisco
            // 
            this.picDisco.Location = new System.Drawing.Point(12, 18);
            this.picDisco.Name = "picDisco";
            this.picDisco.Size = new System.Drawing.Size(123, 106);
            this.picDisco.TabIndex = 0;
            this.picDisco.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMessage.Location = new System.Drawing.Point(129, 156);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 9;
            // 
            // erp
            // 
            this.erp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.erp.ContainerControl = this;
            // 
            // FrmDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtArtisteRecherche);
            this.Controls.Add(this.lblArtisteRecherche);
            this.Controls.Add(this.picDeezer);
            this.Controls.Add(this.picBanniere);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDemarrage";
            this.Text = "Moteur de recherche DEEZER : Version 2";
            this.Activated += new System.EventHandler(this.FrmDemarrage_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDemarrage_FormClosing);
            this.Load += new System.EventHandler(this.FrmDemarrage_Load);
            this.Leave += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).EndInit();
            this.tbpRadio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wbRadio)).EndInit();
            this.tbpArtiste.ResumeLayout(false);
            this.grbArtisteInfos.ResumeLayout(false);
            this.grbArtisteInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).EndInit();
            this.tbc.ResumeLayout(false);
            this.tbpDiscographie.ResumeLayout(false);
            this.pnlDisco.ResumeLayout(false);
            this.pnlDisco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wbDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lectureMultimédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBanniere;
        private System.Windows.Forms.PictureBox picDeezer;
        private System.Windows.Forms.Label lblArtisteRecherche;
        private System.Windows.Forms.TextBox txtArtisteRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TabPage tbpRadio;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbRadio;
        private System.Windows.Forms.TabPage tbpArtiste;
        private System.Windows.Forms.GroupBox grbArtisteInfos;
        private System.Windows.Forms.Button btnEcouterExtraits;
        private System.Windows.Forms.ListBox lstArtistes;
        private System.Windows.Forms.LinkLabel lklDeezerLien;
        private System.Windows.Forms.Label lblArtisteNom;
        private System.Windows.Forms.Label lblArtisteTrouve;
        private System.Windows.Forms.PictureBox picArtiste;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.TabPage tbpDiscographie;
        private System.Windows.Forms.Panel pnlDisco;
        private System.Windows.Forms.PictureBox picDisco;
        private System.Windows.Forms.Label lblTitres;
        private System.Windows.Forms.ListBox lstbTitres;
        private System.Windows.Forms.ListBox lstbAlbums;
        private System.Windows.Forms.Label lblAlbums;
        private System.Windows.Forms.ToolStripMenuItem recherchesToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbDisco;
    }
}

