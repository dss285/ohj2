namespace harjoitustyo_ohj2
{
    partial class Paaikkuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paaikkuna));
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvHenkilot = new System.Windows.Forms.DataGridView();
            this.btnLisaaHenkilo = new System.Windows.Forms.Button();
            this.btnMuokkaaHenkilo = new System.Windows.Forms.Button();
            this.btnLisaaToimisuhde = new System.Windows.Forms.Button();
            this.btnMuokkaaToimisuhde = new System.Windows.Forms.Button();
            this.btnAvaaloki = new System.Windows.Forms.Button();
            this.lblHenkilo = new System.Windows.Forms.Label();
            this.btnTallennaLoki = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.dgvToimisuhteet = new System.Windows.Forms.DataGridView();
            this.btnPoistaToimisuhde = new System.Windows.Forms.Button();
            this.btnPoistaHenkilo = new System.Windows.Forms.Button();
            this.toolstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHenkilot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimisuhteet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolstrip
            // 
            this.toolstrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolstrip.Size = new System.Drawing.Size(800, 25);
            this.toolstrip.TabIndex = 0;
            this.toolstrip.Text = "toolStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileMenu.Image = ((System.Drawing.Image)(resources.GetObject("fileMenu.Image")));
            this.fileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(65, 22);
            this.fileMenu.Text = "Tiedosto";
            this.fileMenu.ToolTipText = "Tiedosto";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Avaa";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Tallenna";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dgvHenkilot
            // 
            this.dgvHenkilot.AllowUserToOrderColumns = true;
            this.dgvHenkilot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHenkilot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHenkilot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHenkilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHenkilot.Location = new System.Drawing.Point(9, 28);
            this.dgvHenkilot.MultiSelect = false;
            this.dgvHenkilot.Name = "dgvHenkilot";
            this.dgvHenkilot.RowHeadersVisible = false;
            this.dgvHenkilot.RowHeadersWidth = 62;
            this.dgvHenkilot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHenkilot.Size = new System.Drawing.Size(595, 223);
            this.dgvHenkilot.TabIndex = 0;
            this.dgvHenkilot.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHenkilot_ColumnHeaderMouseClick);
            this.dgvHenkilot.SelectionChanged += new System.EventHandler(this.dgvHenkilot_SelectionChanged);
            // 
            // btnLisaaHenkilo
            // 
            this.btnLisaaHenkilo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLisaaHenkilo.Location = new System.Drawing.Point(610, 28);
            this.btnLisaaHenkilo.Name = "btnLisaaHenkilo";
            this.btnLisaaHenkilo.Size = new System.Drawing.Size(178, 23);
            this.btnLisaaHenkilo.TabIndex = 1;
            this.btnLisaaHenkilo.Text = "Lisää henkilö";
            this.btnLisaaHenkilo.UseVisualStyleBackColor = true;
            this.btnLisaaHenkilo.Click += new System.EventHandler(this.btnLisaaHenkilo_Click);
            // 
            // btnMuokkaaHenkilo
            // 
            this.btnMuokkaaHenkilo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuokkaaHenkilo.Enabled = false;
            this.btnMuokkaaHenkilo.Location = new System.Drawing.Point(610, 57);
            this.btnMuokkaaHenkilo.Name = "btnMuokkaaHenkilo";
            this.btnMuokkaaHenkilo.Size = new System.Drawing.Size(178, 23);
            this.btnMuokkaaHenkilo.TabIndex = 2;
            this.btnMuokkaaHenkilo.Text = "Muokkaa henkilöä";
            this.btnMuokkaaHenkilo.UseVisualStyleBackColor = true;
            this.btnMuokkaaHenkilo.Click += new System.EventHandler(this.btnMuokkaaHenkilo_Click);
            // 
            // btnLisaaToimisuhde
            // 
            this.btnLisaaToimisuhde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLisaaToimisuhde.Enabled = false;
            this.btnLisaaToimisuhde.Location = new System.Drawing.Point(610, 145);
            this.btnLisaaToimisuhde.Name = "btnLisaaToimisuhde";
            this.btnLisaaToimisuhde.Size = new System.Drawing.Size(177, 23);
            this.btnLisaaToimisuhde.TabIndex = 4;
            this.btnLisaaToimisuhde.Text = "Lisää toimisuhde henkilölle";
            this.btnLisaaToimisuhde.UseVisualStyleBackColor = true;
            this.btnLisaaToimisuhde.Click += new System.EventHandler(this.btnLisaaToimisuhde_Click);
            // 
            // btnMuokkaaToimisuhde
            // 
            this.btnMuokkaaToimisuhde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuokkaaToimisuhde.Enabled = false;
            this.btnMuokkaaToimisuhde.Location = new System.Drawing.Point(610, 174);
            this.btnMuokkaaToimisuhde.Name = "btnMuokkaaToimisuhde";
            this.btnMuokkaaToimisuhde.Size = new System.Drawing.Size(177, 23);
            this.btnMuokkaaToimisuhde.TabIndex = 5;
            this.btnMuokkaaToimisuhde.Text = "Muokkaa toimisuhdetta";
            this.btnMuokkaaToimisuhde.UseVisualStyleBackColor = true;
            this.btnMuokkaaToimisuhde.Click += new System.EventHandler(this.btnMuokkaaToimisuhde_Click);
            // 
            // btnAvaaloki
            // 
            this.btnAvaaloki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAvaaloki.Location = new System.Drawing.Point(609, 403);
            this.btnAvaaloki.Name = "btnAvaaloki";
            this.btnAvaaloki.Size = new System.Drawing.Size(178, 23);
            this.btnAvaaloki.TabIndex = 8;
            this.btnAvaaloki.Text = "Avaa loki";
            this.btnAvaaloki.UseVisualStyleBackColor = true;
            this.btnAvaaloki.Click += new System.EventHandler(this.btnAvaaloki_Click);
            // 
            // lblHenkilo
            // 
            this.lblHenkilo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHenkilo.AutoSize = true;
            this.lblHenkilo.Location = new System.Drawing.Point(611, 126);
            this.lblHenkilo.Name = "lblHenkilo";
            this.lblHenkilo.Size = new System.Drawing.Size(46, 13);
            this.lblHenkilo.TabIndex = 8;
            this.lblHenkilo.Text = "Henkilö:";
            // 
            // btnTallennaLoki
            // 
            this.btnTallennaLoki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTallennaLoki.Location = new System.Drawing.Point(609, 374);
            this.btnTallennaLoki.Name = "btnTallennaLoki";
            this.btnTallennaLoki.Size = new System.Drawing.Size(179, 23);
            this.btnTallennaLoki.TabIndex = 7;
            this.btnTallennaLoki.Text = "Tallenna loki";
            this.btnTallennaLoki.UseVisualStyleBackColor = true;
            this.btnTallennaLoki.Click += new System.EventHandler(this.btnTallennaLoki_Click);
            // 
            // openfile
            // 
            this.openfile.Filter = "Data files (XML, JSON, Binary) | *.xml;*.json;*.dat";
            // 
            // savefile
            // 
            this.savefile.DefaultExt = "json";
            this.savefile.Filter = "Data files (XML, JSON, Binary) | *.xml;*.json;*.dat";
            // 
            // dgvToimisuhteet
            // 
            this.dgvToimisuhteet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToimisuhteet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToimisuhteet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvToimisuhteet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToimisuhteet.Location = new System.Drawing.Point(9, 258);
            this.dgvToimisuhteet.MultiSelect = false;
            this.dgvToimisuhteet.Name = "dgvToimisuhteet";
            this.dgvToimisuhteet.RowHeadersVisible = false;
            this.dgvToimisuhteet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToimisuhteet.Size = new System.Drawing.Size(594, 180);
            this.dgvToimisuhteet.TabIndex = 9;
            this.dgvToimisuhteet.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvToimisuhteet_ColumnHeaderMouseClick);
            this.dgvToimisuhteet.SelectionChanged += new System.EventHandler(this.dgvToimisuhteet_SelectionChanged);
            // 
            // btnPoistaToimisuhde
            // 
            this.btnPoistaToimisuhde.Enabled = false;
            this.btnPoistaToimisuhde.Location = new System.Drawing.Point(610, 203);
            this.btnPoistaToimisuhde.Name = "btnPoistaToimisuhde";
            this.btnPoistaToimisuhde.Size = new System.Drawing.Size(177, 23);
            this.btnPoistaToimisuhde.TabIndex = 6;
            this.btnPoistaToimisuhde.Text = "Poista toimisuhde";
            this.btnPoistaToimisuhde.UseVisualStyleBackColor = true;
            this.btnPoistaToimisuhde.Click += new System.EventHandler(this.btnPoistaToimisuhde_Click);
            // 
            // btnPoistaHenkilo
            // 
            this.btnPoistaHenkilo.Enabled = false;
            this.btnPoistaHenkilo.Location = new System.Drawing.Point(610, 86);
            this.btnPoistaHenkilo.Name = "btnPoistaHenkilo";
            this.btnPoistaHenkilo.Size = new System.Drawing.Size(178, 23);
            this.btnPoistaHenkilo.TabIndex = 3;
            this.btnPoistaHenkilo.Text = "Poista henkilö";
            this.btnPoistaHenkilo.UseVisualStyleBackColor = true;
            this.btnPoistaHenkilo.Click += new System.EventHandler(this.btnPoistaHenkilo_Click);
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPoistaHenkilo);
            this.Controls.Add(this.btnPoistaToimisuhde);
            this.Controls.Add(this.dgvToimisuhteet);
            this.Controls.Add(this.btnTallennaLoki);
            this.Controls.Add(this.lblHenkilo);
            this.Controls.Add(this.btnAvaaloki);
            this.Controls.Add(this.btnMuokkaaToimisuhde);
            this.Controls.Add(this.btnLisaaToimisuhde);
            this.Controls.Add(this.btnMuokkaaHenkilo);
            this.Controls.Add(this.btnLisaaHenkilo);
            this.Controls.Add(this.dgvHenkilot);
            this.Controls.Add(this.toolstrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paaikkuna";
            this.Text = "Henkilöstölista";
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHenkilot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimisuhteet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripDropDownButton fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvHenkilot;
        private System.Windows.Forms.Button btnLisaaHenkilo;
        private System.Windows.Forms.Button btnMuokkaaHenkilo;
        private System.Windows.Forms.Button btnLisaaToimisuhde;
        private System.Windows.Forms.Button btnMuokkaaToimisuhde;
        private System.Windows.Forms.Button btnAvaaloki;
        private System.Windows.Forms.Label lblHenkilo;
        private System.Windows.Forms.Button btnTallennaLoki;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.SaveFileDialog savefile;
        private System.Windows.Forms.DataGridView dgvToimisuhteet;
        private System.Windows.Forms.Button btnPoistaToimisuhde;
        private System.Windows.Forms.Button btnPoistaHenkilo;
    }
}

