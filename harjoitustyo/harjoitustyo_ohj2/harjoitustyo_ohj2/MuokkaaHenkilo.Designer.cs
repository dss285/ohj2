namespace harjoitustyo_ohj2
{
    partial class MuokkaaHenkilo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuokkaaHenkilo));
            this.label1 = new System.Windows.Forms.Label();
            this.cbKutsumanimi = new System.Windows.Forms.ComboBox();
            this.btnMuokkaaHenkilo = new System.Windows.Forms.Button();
            this.lblPostitoimipaikka = new System.Windows.Forms.Label();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.lblPostinumero = new System.Windows.Forms.Label();
            this.lblHetu = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblEtunimet = new System.Windows.Forms.Label();
            this.tbEtunimet = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbHetu = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.errorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kutsumanimi";
            // 
            // cbKutsumanimi
            // 
            this.cbKutsumanimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKutsumanimi.FormattingEnabled = true;
            this.cbKutsumanimi.Location = new System.Drawing.Point(111, 39);
            this.cbKutsumanimi.Name = "cbKutsumanimi";
            this.cbKutsumanimi.Size = new System.Drawing.Size(155, 21);
            this.cbKutsumanimi.TabIndex = 1;
            // 
            // btnMuokkaaHenkilo
            // 
            this.btnMuokkaaHenkilo.Location = new System.Drawing.Point(20, 186);
            this.btnMuokkaaHenkilo.Name = "btnMuokkaaHenkilo";
            this.btnMuokkaaHenkilo.Size = new System.Drawing.Size(249, 23);
            this.btnMuokkaaHenkilo.TabIndex = 7;
            this.btnMuokkaaHenkilo.Text = "Muokkaa henkilöä";
            this.btnMuokkaaHenkilo.UseVisualStyleBackColor = true;
            this.btnMuokkaaHenkilo.Click += new System.EventHandler(this.btnLisaaHenkilo_Click);
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(17, 140);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(83, 13);
            this.lblPostitoimipaikka.TabIndex = 27;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Location = new System.Drawing.Point(43, 164);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(57, 13);
            this.lblKatuosoite.TabIndex = 26;
            this.lblKatuosoite.Text = "Katuosoite";
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.Location = new System.Drawing.Point(35, 116);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(65, 13);
            this.lblPostinumero.TabIndex = 25;
            this.lblPostinumero.Text = "Postinumero";
            // 
            // lblHetu
            // 
            this.lblHetu.AutoSize = true;
            this.lblHetu.Location = new System.Drawing.Point(25, 92);
            this.lblHetu.Name = "lblHetu";
            this.lblHetu.Size = new System.Drawing.Size(75, 13);
            this.lblHetu.TabIndex = 24;
            this.lblHetu.Text = "Henkilötunnus";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(50, 68);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(50, 13);
            this.lblSukunimi.TabIndex = 23;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblEtunimet
            // 
            this.lblEtunimet.AutoSize = true;
            this.lblEtunimet.Location = new System.Drawing.Point(52, 14);
            this.lblEtunimet.Name = "lblEtunimet";
            this.lblEtunimet.Size = new System.Drawing.Size(48, 13);
            this.lblEtunimet.TabIndex = 22;
            this.lblEtunimet.Text = "Etunimet";
            // 
            // tbEtunimet
            // 
            this.tbEtunimet.Enabled = false;
            this.tbEtunimet.Location = new System.Drawing.Point(111, 11);
            this.tbEtunimet.Margin = new System.Windows.Forms.Padding(2);
            this.tbEtunimet.Name = "tbEtunimet";
            this.tbEtunimet.Size = new System.Drawing.Size(155, 20);
            this.tbEtunimet.TabIndex = 0;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(111, 65);
            this.tbSukunimi.Margin = new System.Windows.Forms.Padding(2);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(155, 20);
            this.tbSukunimi.TabIndex = 2;
            // 
            // tbHetu
            // 
            this.tbHetu.Enabled = false;
            this.tbHetu.Location = new System.Drawing.Point(111, 89);
            this.tbHetu.Margin = new System.Windows.Forms.Padding(2);
            this.tbHetu.Name = "tbHetu";
            this.tbHetu.Size = new System.Drawing.Size(155, 20);
            this.tbHetu.TabIndex = 3;
            this.tbHetu.Validating += new System.ComponentModel.CancelEventHandler(this.tbHetu_Validating);
            this.tbHetu.Validated += new System.EventHandler(this.tbHetu_Validated);
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(111, 161);
            this.tbKatuosoite.Margin = new System.Windows.Forms.Padding(2);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(155, 20);
            this.tbKatuosoite.TabIndex = 6;
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(111, 137);
            this.tbPostitoimipaikka.Margin = new System.Windows.Forms.Padding(2);
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(155, 20);
            this.tbPostitoimipaikka.TabIndex = 5;
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbPostinumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbPostinumero.Location = new System.Drawing.Point(111, 113);
            this.tbPostinumero.Margin = new System.Windows.Forms.Padding(2);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(155, 20);
            this.tbPostinumero.TabIndex = 4;
            this.tbPostinumero.TextChanged += new System.EventHandler(this.tbPostinumero_TextChanged);
            // 
            // errorprovider
            // 
            this.errorprovider.ContainerControl = this;
            // 
            // MuokkaaHenkilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKutsumanimi);
            this.Controls.Add(this.btnMuokkaaHenkilo);
            this.Controls.Add(this.lblPostitoimipaikka);
            this.Controls.Add(this.lblKatuosoite);
            this.Controls.Add(this.lblPostinumero);
            this.Controls.Add(this.lblHetu);
            this.Controls.Add(this.lblSukunimi);
            this.Controls.Add(this.lblEtunimet);
            this.Controls.Add(this.tbEtunimet);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbHetu);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbPostitoimipaikka);
            this.Controls.Add(this.tbPostinumero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(303, 264);
            this.Name = "MuokkaaHenkilo";
            this.Text = "Muokkaa";
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKutsumanimi;
        private System.Windows.Forms.Button btnMuokkaaHenkilo;
        private System.Windows.Forms.Label lblPostitoimipaikka;
        private System.Windows.Forms.Label lblKatuosoite;
        private System.Windows.Forms.Label lblPostinumero;
        private System.Windows.Forms.Label lblHetu;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblEtunimet;
        private System.Windows.Forms.TextBox tbEtunimet;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbHetu;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbPostitoimipaikka;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.ErrorProvider errorprovider;
    }
}