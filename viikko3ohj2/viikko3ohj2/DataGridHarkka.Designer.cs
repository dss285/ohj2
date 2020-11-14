namespace viikko3ohj2
{
    partial class DataGridHarkka
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.calKalenteri = new System.Windows.Forms.MonthCalendar();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.cbSyy = new System.Windows.Forms.ComboBox();
            this.lblSyy = new System.Windows.Forms.Label();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(17, 364);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(922, 227);
            this.dgv.TabIndex = 0;
            this.dgv.Click += new System.EventHandler(this.Dgv_Click);
            // 
            // calKalenteri
            // 
            this.calKalenteri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calKalenteri.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.calKalenteri.Location = new System.Drawing.Point(18, 72);
            this.calKalenteri.MaxSelectionCount = 100;
            this.calKalenteri.Name = "calKalenteri";
            this.calKalenteri.ShowWeekNumbers = true;
            this.calKalenteri.TabIndex = 1;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLisaa.Location = new System.Drawing.Point(965, 364);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(94, 64);
            this.btnLisaa.TabIndex = 2;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.BtnLisaa_Click);
            // 
            // cbSyy
            // 
            this.cbSyy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSyy.FormattingEnabled = true;
            this.cbSyy.Location = new System.Drawing.Point(131, 32);
            this.cbSyy.Name = "cbSyy";
            this.cbSyy.Size = new System.Drawing.Size(200, 28);
            this.cbSyy.TabIndex = 5;
            // 
            // lblSyy
            // 
            this.lblSyy.AutoSize = true;
            this.lblSyy.Location = new System.Drawing.Point(13, 35);
            this.lblSyy.Name = "lblSyy";
            this.lblSyy.Size = new System.Drawing.Size(112, 20);
            this.lblSyy.TabIndex = 6;
            this.lblSyy.Text = "Poissaolon syy";
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuokkaa.Location = new System.Drawing.Point(965, 444);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(94, 64);
            this.btnMuokkaa.TabIndex = 7;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.BtnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoista.Location = new System.Drawing.Point(965, 527);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(94, 64);
            this.btnPoista.TabIndex = 8;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.BtnPoista_Click);
            // 
            // DataGridHarkka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1071, 611);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.lblSyy);
            this.Controls.Add(this.cbSyy);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.calKalenteri);
            this.Controls.Add(this.dgv);
            this.MinimumSize = new System.Drawing.Size(1093, 667);
            this.Name = "DataGridHarkka";
            this.Text = "GridHarkka";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.MonthCalendar calKalenteri;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.ComboBox cbSyy;
        private System.Windows.Forms.Label lblSyy;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
    }
}

