namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Siyah_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siyah_İşareti));
            this.pbsiyah2 = new System.Windows.Forms.PictureBox();
            this.tbsiyahaçıklaması = new System.Windows.Forms.TextBox();
            this.pbsiyah1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbsiyah2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsiyah1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbsiyah2
            // 
            this.pbsiyah2.Image = ((System.Drawing.Image)(resources.GetObject("pbsiyah2.Image")));
            this.pbsiyah2.Location = new System.Drawing.Point(395, 27);
            this.pbsiyah2.Name = "pbsiyah2";
            this.pbsiyah2.Size = new System.Drawing.Size(176, 225);
            this.pbsiyah2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsiyah2.TabIndex = 12;
            this.pbsiyah2.TabStop = false;
            // 
            // tbsiyahaçıklaması
            // 
            this.tbsiyahaçıklaması.Location = new System.Drawing.Point(50, 275);
            this.tbsiyahaçıklaması.Multiline = true;
            this.tbsiyahaçıklaması.Name = "tbsiyahaçıklaması";
            this.tbsiyahaçıklaması.Size = new System.Drawing.Size(550, 44);
            this.tbsiyahaçıklaması.TabIndex = 11;
            this.tbsiyahaçıklaması.Text = "İşaret dilinde siyah işareti yapabilmek için elimizi yüzümüze götürüp 5 parmağımı" +
    "zı da açıp aşağı doğru indirmemiz gerekir.";
            this.tbsiyahaçıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbsiyah1
            // 
            this.pbsiyah1.Image = ((System.Drawing.Image)(resources.GetObject("pbsiyah1.Image")));
            this.pbsiyah1.Location = new System.Drawing.Point(76, 27);
            this.pbsiyah1.Name = "pbsiyah1";
            this.pbsiyah1.Size = new System.Drawing.Size(176, 225);
            this.pbsiyah1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsiyah1.TabIndex = 10;
            this.pbsiyah1.TabStop = false;
            // 
            // Siyah_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.pbsiyah2);
            this.Controls.Add(this.tbsiyahaçıklaması);
            this.Controls.Add(this.pbsiyah1);
            this.Name = "Siyah_İşareti";
            this.Text = "Siyah İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pbsiyah2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsiyah1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbsiyah2;
        private System.Windows.Forms.TextBox tbsiyahaçıklaması;
        private System.Windows.Forms.PictureBox pbsiyah1;
    }
}