namespace harjoitustyo_ohj2
{
    partial class LisaaHenkilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LisaaHenkilo));
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.tbPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbHetu = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimet = new System.Windows.Forms.TextBox();
            this.lblEtunimet = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblHetu = new System.Windows.Forms.Label();
            this.lblPostinumero = new System.Windows.Forms.Label();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.lblPostitoimipaikka = new System.Windows.Forms.Label();
            this.btnLisaaHenkilo = new System.Windows.Forms.Button();
            this.errorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbKutsumanimi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Location = new System.Drawing.Point(108, 113);
            this.tbPostinumero.Margin = new System.Windows.Forms.Padding(2);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(155, 20);
            this.tbPostinumero.TabIndex = 4;
            this.tbPostinumero.TextChanged += new System.EventHandler(this.tbPostinumero_TextChanged);
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(108, 137);
            this.tbPostitoimipaikka.Margin = new System.Windows.Forms.Padding(2);
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(155, 20);
            this.tbPostitoimipaikka.TabIndex = 5;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(108, 161);
            this.tbKatuosoite.Margin = new System.Windows.Forms.Padding(2);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(155, 20);
            this.tbKatuosoite.TabIndex = 6;
            // 
            // tbHetu
            // 
            this.tbHetu.Location = new System.Drawing.Point(108, 89);
            this.tbHetu.Margin = new System.Windows.Forms.Padding(2);
            this.tbHetu.Name = "tbHetu";
            this.tbHetu.Size = new System.Drawing.Size(155, 20);
            this.tbHetu.TabIndex = 3;
            this.tbHetu.Validating += new System.ComponentModel.CancelEventHandler(this.tbHetu_Validating);
            this.tbHetu.Validated += new System.EventHandler(this.tbHetu_Validated);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(108, 65);
            this.tbSukunimi.Margin = new System.Windows.Forms.Padding(2);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(155, 20);
            this.tbSukunimi.TabIndex = 2;
            // 
            // tbEtunimet
            // 
            this.tbEtunimet.Location = new System.Drawing.Point(108, 11);
            this.tbEtunimet.Margin = new System.Windows.Forms.Padding(2);
            this.tbEtunimet.Name = "tbEtunimet";
            this.tbEtunimet.Size = new System.Drawing.Size(155, 20);
            this.tbEtunimet.TabIndex = 0;
            this.tbEtunimet.Leave += new System.EventHandler(this.tbEtunimet_Leave);
            // 
            // lblEtunimet
            // 
            this.lblEtunimet.AutoSize = true;
            this.lblEtunimet.Location = new System.Drawing.Point(49, 14);
            this.lblEtunimet.Name = "lblEtunimet";
            this.lblEtunimet.Size = new System.Drawing.Size(48, 13);
            this.lblEtunimet.TabIndex = 7;
            this.lblEtunimet.Text = "Etunimet";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(47, 68);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(50, 13);
            this.lblSukunimi.TabIndex = 8;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblHetu
            // 
            this.lblHetu.AutoSize = true;
            this.lblHetu.Location = new System.Drawing.Point(22, 92);
            this.lblHetu.Name = "lblHetu";
            this.lblHetu.Size = new System.Drawing.Size(75, 13);
            this.lblHetu.TabIndex = 9;
            this.lblHetu.Text = "Henkilötunnus";
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.Location = new System.Drawing.Point(32, 116);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(65, 13);
            this.lblPostinumero.TabIndex = 10;
            this.lblPostinumero.Text = "Postinumero";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Location = new System.Drawing.Point(40, 164);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(57, 13);
            this.lblKatuosoite.TabIndex = 11;
            this.lblKatuosoite.Text = "Katuosoite";
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(14, 140);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(83, 13);
            this.lblPostitoimipaikka.TabIndex = 12;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // btnLisaaHenkilo
            // 
            this.btnLisaaHenkilo.Location = new System.Drawing.Point(17, 186);
            this.btnLisaaHenkilo.Name = "btnLisaaHenkilo";
            this.btnLisaaHenkilo.Size = new System.Drawing.Size(249, 23);
            this.btnLisaaHenkilo.TabIndex = 7;
            this.btnLisaaHenkilo.Text = "Lisää henkilö";
            this.btnLisaaHenkilo.UseVisualStyleBackColor = true;
            this.btnLisaaHenkilo.Click += new System.EventHandler(this.btnLisaaHenkilo_Click);
            // 
            // errorprovider
            // 
            this.errorprovider.ContainerControl = this;
            // 
            // cbKutsumanimi
            // 
            this.cbKutsumanimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKutsumanimi.FormattingEnabled = true;
            this.cbKutsumanimi.Location = new System.Drawing.Point(108, 39);
            this.cbKutsumanimi.Name = "cbKutsumanimi";
            this.cbKutsumanimi.Size = new System.Drawing.Size(155, 21);
            this.cbKutsumanimi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kutsumanimi";
            // 
            // LisaaHenkilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKutsumanimi);
            this.Controls.Add(this.btnLisaaHenkilo);
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
            this.Name = "LisaaHenkilo";
            this.Text = "Lisää";
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.TextBox tbPostitoimipaikka;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbHetu;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimet;
        private System.Windows.Forms.Label lblEtunimet;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblHetu;
        private System.Windows.Forms.Label lblPostinumero;
        private System.Windows.Forms.Label lblKatuosoite;
        private System.Windows.Forms.Label lblPostitoimipaikka;
        private System.Windows.Forms.Button btnLisaaHenkilo;
        private System.Windows.Forms.ErrorProvider errorprovider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKutsumanimi;
    }
}