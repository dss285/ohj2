namespace harjoitustyo_ohj2
{
    partial class MuokkaaToimisuhde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuokkaaToimisuhde));
            this.btnMuokkaaToimisuhde = new System.Windows.Forms.Button();
            this.lblYksikko = new System.Windows.Forms.Label();
            this.lblNimike = new System.Windows.Forms.Label();
            this.tbYksikko = new System.Windows.Forms.TextBox();
            this.tbNimike = new System.Windows.Forms.TextBox();
            this.checkToistaiseksi = new System.Windows.Forms.CheckBox();
            this.lblPaattyy = new System.Windows.Forms.Label();
            this.lblAlkaa = new System.Windows.Forms.Label();
            this.datetimePaattyy = new System.Windows.Forms.DateTimePicker();
            this.datetimeAlkaa = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnMuokkaaToimisuhde
            // 
            this.btnMuokkaaToimisuhde.Location = new System.Drawing.Point(36, 164);
            this.btnMuokkaaToimisuhde.Name = "btnMuokkaaToimisuhde";
            this.btnMuokkaaToimisuhde.Size = new System.Drawing.Size(244, 23);
            this.btnMuokkaaToimisuhde.TabIndex = 5;
            this.btnMuokkaaToimisuhde.Text = "Muokkaa toimisuhdetta";
            this.btnMuokkaaToimisuhde.UseVisualStyleBackColor = true;
            this.btnMuokkaaToimisuhde.Click += new System.EventHandler(this.btnMuokkaaToimisuhde_Click);
            // 
            // lblYksikko
            // 
            this.lblYksikko.AutoSize = true;
            this.lblYksikko.Location = new System.Drawing.Point(33, 40);
            this.lblYksikko.Name = "lblYksikko";
            this.lblYksikko.Size = new System.Drawing.Size(45, 13);
            this.lblYksikko.TabIndex = 18;
            this.lblYksikko.Text = "Yksikkö";
            // 
            // lblNimike
            // 
            this.lblNimike.AutoSize = true;
            this.lblNimike.Location = new System.Drawing.Point(33, 66);
            this.lblNimike.Name = "lblNimike";
            this.lblNimike.Size = new System.Drawing.Size(39, 13);
            this.lblNimike.TabIndex = 17;
            this.lblNimike.Text = "Nimike";
            // 
            // tbYksikko
            // 
            this.tbYksikko.Location = new System.Drawing.Point(81, 37);
            this.tbYksikko.Name = "tbYksikko";
            this.tbYksikko.Size = new System.Drawing.Size(199, 20);
            this.tbYksikko.TabIndex = 0;
            // 
            // tbNimike
            // 
            this.tbNimike.Location = new System.Drawing.Point(81, 63);
            this.tbNimike.Name = "tbNimike";
            this.tbNimike.Size = new System.Drawing.Size(199, 20);
            this.tbNimike.TabIndex = 1;
            // 
            // checkToistaiseksi
            // 
            this.checkToistaiseksi.AutoSize = true;
            this.checkToistaiseksi.Location = new System.Drawing.Point(114, 115);
            this.checkToistaiseksi.Name = "checkToistaiseksi";
            this.checkToistaiseksi.Size = new System.Drawing.Size(166, 17);
            this.checkToistaiseksi.TabIndex = 3;
            this.checkToistaiseksi.Text = "Toistaiseksi voimassa oleva ?";
            this.checkToistaiseksi.UseVisualStyleBackColor = true;
            this.checkToistaiseksi.CheckedChanged += new System.EventHandler(this.checkToistaiseksi_CheckedChanged);
            // 
            // lblPaattyy
            // 
            this.lblPaattyy.AutoSize = true;
            this.lblPaattyy.Location = new System.Drawing.Point(33, 145);
            this.lblPaattyy.Name = "lblPaattyy";
            this.lblPaattyy.Size = new System.Drawing.Size(42, 13);
            this.lblPaattyy.TabIndex = 13;
            this.lblPaattyy.Text = "Päättyy";
            // 
            // lblAlkaa
            // 
            this.lblAlkaa.AutoSize = true;
            this.lblAlkaa.Location = new System.Drawing.Point(33, 95);
            this.lblAlkaa.Name = "lblAlkaa";
            this.lblAlkaa.Size = new System.Drawing.Size(34, 13);
            this.lblAlkaa.TabIndex = 12;
            this.lblAlkaa.Text = "Alkaa";
            // 
            // datetimePaattyy
            // 
            this.datetimePaattyy.Location = new System.Drawing.Point(81, 138);
            this.datetimePaattyy.Name = "datetimePaattyy";
            this.datetimePaattyy.Size = new System.Drawing.Size(199, 20);
            this.datetimePaattyy.TabIndex = 4;
            // 
            // datetimeAlkaa
            // 
            this.datetimeAlkaa.Location = new System.Drawing.Point(81, 89);
            this.datetimeAlkaa.Name = "datetimeAlkaa";
            this.datetimeAlkaa.Size = new System.Drawing.Size(199, 20);
            this.datetimeAlkaa.TabIndex = 2;
            // 
            // MuokkaaToimisuhde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 226);
            this.Controls.Add(this.btnMuokkaaToimisuhde);
            this.Controls.Add(this.lblYksikko);
            this.Controls.Add(this.lblNimike);
            this.Controls.Add(this.tbYksikko);
            this.Controls.Add(this.tbNimike);
            this.Controls.Add(this.checkToistaiseksi);
            this.Controls.Add(this.lblPaattyy);
            this.Controls.Add(this.lblAlkaa);
            this.Controls.Add(this.datetimePaattyy);
            this.Controls.Add(this.datetimeAlkaa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(336, 265);
            this.Name = "MuokkaaToimisuhde";
            this.Text = "Muokkaa Toimisuhdetta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMuokkaaToimisuhde;
        private System.Windows.Forms.Label lblYksikko;
        private System.Windows.Forms.Label lblNimike;
        private System.Windows.Forms.TextBox tbYksikko;
        private System.Windows.Forms.TextBox tbNimike;
        private System.Windows.Forms.CheckBox checkToistaiseksi;
        private System.Windows.Forms.Label lblPaattyy;
        private System.Windows.Forms.Label lblAlkaa;
        private System.Windows.Forms.DateTimePicker datetimePaattyy;
        private System.Windows.Forms.DateTimePicker datetimeAlkaa;
    }
}