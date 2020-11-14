namespace harjoitustyo_ohj2
{
    partial class Loki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loki));
            this.lbLoki = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbLoki
            // 
            this.lbLoki.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoki.FormattingEnabled = true;
            this.lbLoki.ItemHeight = 25;
            this.lbLoki.Location = new System.Drawing.Point(12, 49);
            this.lbLoki.Name = "lbLoki";
            this.lbLoki.Size = new System.Drawing.Size(775, 354);
            this.lbLoki.TabIndex = 0;
            // 
            // Loki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLoki);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loki";
            this.Text = "Loki";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLoki;
    }
}