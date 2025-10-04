namespace ZiKnCo_MoteurRechercheDeezer
{
    partial class FrmPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlaylist));
            this.lstGauche1 = new System.Windows.Forms.ListBox();
            this.lstDroite = new System.Windows.Forms.ListBox();
            this.lstGauche = new System.Windows.Forms.Label();
            this.lblDroite = new System.Windows.Forms.Label();
            this.btnUnD = new System.Windows.Forms.Button();
            this.btnTousD = new System.Windows.Forms.Button();
            this.btnUnG = new System.Windows.Forms.Button();
            this.btnTousNoir = new System.Windows.Forms.Button();
            this.btnJouerExtrait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGauche1
            // 
            this.lstGauche1.FormattingEnabled = true;
            this.lstGauche1.Location = new System.Drawing.Point(42, 74);
            this.lstGauche1.Name = "lstGauche1";
            this.lstGauche1.Size = new System.Drawing.Size(135, 186);
            this.lstGauche1.TabIndex = 0;
            this.lstGauche1.SelectedIndexChanged += new System.EventHandler(this.lstGauche1_SelectedIndexChanged);
            // 
            // lstDroite
            // 
            this.lstDroite.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstDroite.FormattingEnabled = true;
            this.lstDroite.Location = new System.Drawing.Point(306, 74);
            this.lstDroite.Name = "lstDroite";
            this.lstDroite.Size = new System.Drawing.Size(138, 186);
            this.lstDroite.TabIndex = 1;
            // 
            // lstGauche
            // 
            this.lstGauche.AutoSize = true;
            this.lstGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGauche.Location = new System.Drawing.Point(39, 42);
            this.lstGauche.Name = "lstGauche";
            this.lstGauche.Size = new System.Drawing.Size(110, 13);
            this.lstGauche.TabIndex = 2;
            this.lstGauche.Text = "Morceaux de l\'album :";
            // 
            // lblDroite
            // 
            this.lblDroite.AutoSize = true;
            this.lblDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroite.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDroite.Location = new System.Drawing.Point(303, 42);
            this.lblDroite.Name = "lblDroite";
            this.lblDroite.Size = new System.Drawing.Size(129, 13);
            this.lblDroite.TabIndex = 3;
            this.lblDroite.Text = "Morceaux choisis playlist :";
            // 
            // btnUnD
            // 
            this.btnUnD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUnD.Location = new System.Drawing.Point(192, 74);
            this.btnUnD.Name = "btnUnD";
            this.btnUnD.Size = new System.Drawing.Size(95, 28);
            this.btnUnD.TabIndex = 4;
            this.btnUnD.Text = "> Un";
            this.btnUnD.UseVisualStyleBackColor = true;
            this.btnUnD.Click += new System.EventHandler(this.btnUnD_Click);
            // 
            // btnTousD
            // 
            this.btnTousD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTousD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTousD.Location = new System.Drawing.Point(192, 108);
            this.btnTousD.Name = "btnTousD";
            this.btnTousD.Size = new System.Drawing.Size(95, 27);
            this.btnTousD.TabIndex = 5;
            this.btnTousD.Text = ">> Tous";
            this.btnTousD.UseVisualStyleBackColor = false;
            this.btnTousD.Click += new System.EventHandler(this.btnTousD_Click);
            // 
            // btnUnG
            // 
            this.btnUnG.Location = new System.Drawing.Point(192, 186);
            this.btnUnG.Name = "btnUnG";
            this.btnUnG.Size = new System.Drawing.Size(95, 30);
            this.btnUnG.TabIndex = 6;
            this.btnUnG.Text = "< Un";
            this.btnUnG.UseVisualStyleBackColor = true;
            this.btnUnG.Click += new System.EventHandler(this.btnUnG_Click);
            // 
            // btnTousNoir
            // 
            this.btnTousNoir.Location = new System.Drawing.Point(192, 222);
            this.btnTousNoir.Name = "btnTousNoir";
            this.btnTousNoir.Size = new System.Drawing.Size(95, 25);
            this.btnTousNoir.TabIndex = 7;
            this.btnTousNoir.Text = "<< Tous";
            this.btnTousNoir.UseVisualStyleBackColor = true;
            this.btnTousNoir.Click += new System.EventHandler(this.btnTousNoir_Click);
            // 
            // btnJouerExtrait
            // 
            this.btnJouerExtrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouerExtrait.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnJouerExtrait.Location = new System.Drawing.Point(306, 266);
            this.btnJouerExtrait.Name = "btnJouerExtrait";
            this.btnJouerExtrait.Size = new System.Drawing.Size(138, 24);
            this.btnJouerExtrait.TabIndex = 8;
            this.btnJouerExtrait.Text = "Jouer les extraits";
            this.btnJouerExtrait.UseVisualStyleBackColor = true;
            // 
            // FrmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 307);
            this.Controls.Add(this.btnJouerExtrait);
            this.Controls.Add(this.btnTousNoir);
            this.Controls.Add(this.btnUnG);
            this.Controls.Add(this.btnTousD);
            this.Controls.Add(this.btnUnD);
            this.Controls.Add(this.lblDroite);
            this.Controls.Add(this.lstGauche);
            this.Controls.Add(this.lstDroite);
            this.Controls.Add(this.lstGauche1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPlaylist";
            this.Text = "PLAYLIST des Extraits de l\'album";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstDroite;
        private System.Windows.Forms.Label lstGauche;
        private System.Windows.Forms.Label lblDroite;
        private System.Windows.Forms.Button btnUnD;
        private System.Windows.Forms.Button btnTousD;
        private System.Windows.Forms.Button btnUnG;
        private System.Windows.Forms.Button btnTousNoir;
        private System.Windows.Forms.Button btnJouerExtrait;
        public System.Windows.Forms.ListBox lstGauche1;
    }
}