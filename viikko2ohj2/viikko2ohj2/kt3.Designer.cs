namespace viikko2ohj2
{
    partial class kt3
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
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPuhNro = new System.Windows.Forms.TextBox();
            this.tbOsoite = new System.Windows.Forms.TextBox();
            this.tbPostiNro = new System.Windows.Forms.TextBox();
            this.tbPostiToimipaikka = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPuhNro = new System.Windows.Forms.Label();
            this.lblOsoite = new System.Windows.Forms.Label();
            this.lblPostiNro = new System.Windows.Forms.Label();
            this.lblPostiToimipaikka = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lbHenkilot = new System.Windows.Forms.ListBox();
            this.btnVie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(52, 358);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(273, 26);
            this.dtpDateOfBirth.TabIndex = 7;
            this.dtpDateOfBirth.Leave += new System.EventHandler(this.DtpDateOfBirth_Leave);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(52, 31);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(273, 26);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(52, 87);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(273, 26);
            this.tbLastName.TabIndex = 2;
            // 
            // tbPuhNro
            // 
            this.tbPuhNro.Location = new System.Drawing.Point(52, 138);
            this.tbPuhNro.Name = "tbPuhNro";
            this.tbPuhNro.Size = new System.Drawing.Size(273, 26);
            this.tbPuhNro.TabIndex = 3;
            this.tbPuhNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPostiNro_KeyPress);
            // 
            // tbOsoite
            // 
            this.tbOsoite.Location = new System.Drawing.Point(52, 194);
            this.tbOsoite.Name = "tbOsoite";
            this.tbOsoite.Size = new System.Drawing.Size(273, 26);
            this.tbOsoite.TabIndex = 4;
            // 
            // tbPostiNro
            // 
            this.tbPostiNro.Location = new System.Drawing.Point(52, 250);
            this.tbPostiNro.Name = "tbPostiNro";
            this.tbPostiNro.Size = new System.Drawing.Size(273, 26);
            this.tbPostiNro.TabIndex = 5;
            this.tbPostiNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPostiNro_KeyPress);
            // 
            // tbPostiToimipaikka
            // 
            this.tbPostiToimipaikka.Location = new System.Drawing.Point(52, 306);
            this.tbPostiToimipaikka.Name = "tbPostiToimipaikka";
            this.tbPostiToimipaikka.Size = new System.Drawing.Size(273, 26);
            this.tbPostiToimipaikka.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(48, 8);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(62, 20);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "Etunimi";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(48, 64);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(74, 20);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Sukunimi";
            // 
            // lblPuhNro
            // 
            this.lblPuhNro.AutoSize = true;
            this.lblPuhNro.Location = new System.Drawing.Point(48, 115);
            this.lblPuhNro.Name = "lblPuhNro";
            this.lblPuhNro.Size = new System.Drawing.Size(115, 20);
            this.lblPuhNro.TabIndex = 9;
            this.lblPuhNro.Text = "Puhelinnumero";
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.Location = new System.Drawing.Point(48, 171);
            this.lblOsoite.Name = "lblOsoite";
            this.lblOsoite.Size = new System.Drawing.Size(55, 20);
            this.lblOsoite.TabIndex = 10;
            this.lblOsoite.Text = "Osoite";
            // 
            // lblPostiNro
            // 
            this.lblPostiNro.AutoSize = true;
            this.lblPostiNro.Location = new System.Drawing.Point(48, 227);
            this.lblPostiNro.Name = "lblPostiNro";
            this.lblPostiNro.Size = new System.Drawing.Size(98, 20);
            this.lblPostiNro.TabIndex = 11;
            this.lblPostiNro.Text = "Postinumero";
            // 
            // lblPostiToimipaikka
            // 
            this.lblPostiToimipaikka.AutoSize = true;
            this.lblPostiToimipaikka.Location = new System.Drawing.Point(48, 283);
            this.lblPostiToimipaikka.Name = "lblPostiToimipaikka";
            this.lblPostiToimipaikka.Size = new System.Drawing.Size(131, 20);
            this.lblPostiToimipaikka.TabIndex = 12;
            this.lblPostiToimipaikka.Text = "Posti Toimipaikka";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(48, 335);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(107, 20);
            this.lblDateOfBirth.TabIndex = 13;
            this.lblDateOfBirth.Text = "Syntymäpäivä";
            // 
            // lbHenkilot
            // 
            this.lbHenkilot.FormattingEnabled = true;
            this.lbHenkilot.ItemHeight = 20;
            this.lbHenkilot.Location = new System.Drawing.Point(389, 11);
            this.lbHenkilot.Name = "lbHenkilot";
            this.lbHenkilot.Size = new System.Drawing.Size(247, 424);
            this.lbHenkilot.TabIndex = 9;
            this.lbHenkilot.Click += new System.EventHandler(this.LbHenkilot_Click);
            // 
            // btnVie
            // 
            this.btnVie.Location = new System.Drawing.Point(52, 400);
            this.btnVie.Name = "btnVie";
            this.btnVie.Size = new System.Drawing.Size(273, 35);
            this.btnVie.TabIndex = 8;
            this.btnVie.Text = "Vie";
            this.btnVie.UseVisualStyleBackColor = true;
            this.btnVie.Click += new System.EventHandler(this.BtnVie_Click);
            // 
            // kt3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.btnVie);
            this.Controls.Add(this.lbHenkilot);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblPostiToimipaikka);
            this.Controls.Add(this.lblPostiNro);
            this.Controls.Add(this.lblOsoite);
            this.Controls.Add(this.lblPuhNro);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbPostiToimipaikka);
            this.Controls.Add(this.tbPostiNro);
            this.Controls.Add(this.tbOsoite);
            this.Controls.Add(this.tbPuhNro);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Name = "kt3";
            this.Text = "Lomake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbPuhNro;
        private System.Windows.Forms.TextBox tbOsoite;
        private System.Windows.Forms.TextBox tbPostiNro;
        private System.Windows.Forms.TextBox tbPostiToimipaikka;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPuhNro;
        private System.Windows.Forms.Label lblOsoite;
        private System.Windows.Forms.Label lblPostiNro;
        private System.Windows.Forms.Label lblPostiToimipaikka;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.ListBox lbHenkilot;
        private System.Windows.Forms.Button btnVie;
    }
}