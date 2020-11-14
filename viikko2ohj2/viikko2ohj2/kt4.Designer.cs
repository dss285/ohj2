namespace viikko2ohj2
{
    partial class kt4
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
            this.lblNimi = new System.Windows.Forms.Label();
            this.lblArvo = new System.Windows.Forms.Label();
            this.checkToiminnassa = new System.Windows.Forms.CheckBox();
            this.lblSijainti = new System.Windows.Forms.Label();
            this.dgvKomponentit = new System.Windows.Forms.DataGridView();
            this.cbArvo = new System.Windows.Forms.ComboBox();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.cbSijainti = new System.Windows.Forms.ComboBox();
            this.btnVie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponentit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Location = new System.Drawing.Point(30, 22);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(39, 20);
            this.lblNimi.TabIndex = 0;
            this.lblNimi.Text = "Nimi";
            // 
            // lblArvo
            // 
            this.lblArvo.AutoSize = true;
            this.lblArvo.Location = new System.Drawing.Point(371, 21);
            this.lblArvo.Name = "lblArvo";
            this.lblArvo.Size = new System.Drawing.Size(110, 20);
            this.lblArvo.TabIndex = 1;
            this.lblArvo.Text = "Mitattava Arvo";
            // 
            // checkToiminnassa
            // 
            this.checkToiminnassa.AutoSize = true;
            this.checkToiminnassa.Location = new System.Drawing.Point(164, 57);
            this.checkToiminnassa.Name = "checkToiminnassa";
            this.checkToiminnassa.Size = new System.Drawing.Size(124, 24);
            this.checkToiminnassa.TabIndex = 2;
            this.checkToiminnassa.Text = "Toiminnassa";
            this.checkToiminnassa.UseVisualStyleBackColor = true;
            // 
            // lblSijainti
            // 
            this.lblSijainti.AutoSize = true;
            this.lblSijainti.Location = new System.Drawing.Point(426, 56);
            this.lblSijainti.Name = "lblSijainti";
            this.lblSijainti.Size = new System.Drawing.Size(55, 20);
            this.lblSijainti.TabIndex = 3;
            this.lblSijainti.Text = "Sijainti";
            // 
            // dgvKomponentit
            // 
            this.dgvKomponentit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKomponentit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomponentit.Location = new System.Drawing.Point(12, 140);
            this.dgvKomponentit.Name = "dgvKomponentit";
            this.dgvKomponentit.RowHeadersWidth = 62;
            this.dgvKomponentit.RowTemplate.Height = 28;
            this.dgvKomponentit.Size = new System.Drawing.Size(776, 298);
            this.dgvKomponentit.TabIndex = 4;
            // 
            // cbArvo
            // 
            this.cbArvo.FormattingEnabled = true;
            this.cbArvo.Location = new System.Drawing.Point(487, 19);
            this.cbArvo.Name = "cbArvo";
            this.cbArvo.Size = new System.Drawing.Size(170, 28);
            this.cbArvo.TabIndex = 5;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(164, 18);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(170, 26);
            this.tbNimi.TabIndex = 6;
            // 
            // cbSijainti
            // 
            this.cbSijainti.FormattingEnabled = true;
            this.cbSijainti.Location = new System.Drawing.Point(487, 53);
            this.cbSijainti.Name = "cbSijainti";
            this.cbSijainti.Size = new System.Drawing.Size(170, 28);
            this.cbSijainti.TabIndex = 7;
            // 
            // btnVie
            // 
            this.btnVie.Location = new System.Drawing.Point(663, 21);
            this.btnVie.Name = "btnVie";
            this.btnVie.Size = new System.Drawing.Size(125, 60);
            this.btnVie.TabIndex = 8;
            this.btnVie.Text = "Vie";
            this.btnVie.UseVisualStyleBackColor = true;
            this.btnVie.Click += new System.EventHandler(this.BtnVie_Click);
            // 
            // kt4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVie);
            this.Controls.Add(this.cbSijainti);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.cbArvo);
            this.Controls.Add(this.dgvKomponentit);
            this.Controls.Add(this.lblSijainti);
            this.Controls.Add(this.checkToiminnassa);
            this.Controls.Add(this.lblArvo);
            this.Controls.Add(this.lblNimi);
            this.Name = "kt4";
            this.Text = "Mittaus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponentit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.Label lblArvo;
        private System.Windows.Forms.CheckBox checkToiminnassa;
        private System.Windows.Forms.Label lblSijainti;
        private System.Windows.Forms.DataGridView dgvKomponentit;
        private System.Windows.Forms.ComboBox cbArvo;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.ComboBox cbSijainti;
        private System.Windows.Forms.Button btnVie;
    }
}