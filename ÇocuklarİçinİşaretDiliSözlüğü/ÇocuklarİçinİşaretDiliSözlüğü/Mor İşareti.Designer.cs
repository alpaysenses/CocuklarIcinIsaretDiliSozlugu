namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Mor_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mor_İşareti));
            this.pbmor2 = new System.Windows.Forms.PictureBox();
            this.tbmoraçıklaması = new System.Windows.Forms.TextBox();
            this.pbmor1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbmor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmor1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbmor2
            // 
            this.pbmor2.Image = ((System.Drawing.Image)(resources.GetObject("pbmor2.Image")));
            this.pbmor2.Location = new System.Drawing.Point(395, 27);
            this.pbmor2.Name = "pbmor2";
            this.pbmor2.Size = new System.Drawing.Size(176, 225);
            this.pbmor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmor2.TabIndex = 21;
            this.pbmor2.TabStop = false;
            // 
            // tbmoraçıklaması
            // 
            this.tbmoraçıklaması.Location = new System.Drawing.Point(50, 275);
            this.tbmoraçıklaması.Multiline = true;
            this.tbmoraçıklaması.Name = "tbmoraçıklaması";
            this.tbmoraçıklaması.Size = new System.Drawing.Size(550, 44);
            this.tbmoraçıklaması.TabIndex = 20;
            this.tbmoraçıklaması.Text = "İşaret dilinde mor işareti yapabilmek için  sol ve sağ elimizle iki yapıp işaret " +
    "parmaklarını birleştirdikten sonra elimizi yukarıya doğru kaldırmamız gerekir.";
            this.tbmoraçıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbmor1
            // 
            this.pbmor1.Image = ((System.Drawing.Image)(resources.GetObject("pbmor1.Image")));
            this.pbmor1.Location = new System.Drawing.Point(76, 27);
            this.pbmor1.Name = "pbmor1";
            this.pbmor1.Size = new System.Drawing.Size(176, 225);
            this.pbmor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmor1.TabIndex = 19;
            this.pbmor1.TabStop = false;
            // 
            // Mor_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.pbmor2);
            this.Controls.Add(this.tbmoraçıklaması);
            this.Controls.Add(this.pbmor1);
            this.Name = "Mor_İşareti";
            this.Text = "Mor İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pbmor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbmor2;
        private System.Windows.Forms.TextBox tbmoraçıklaması;
        private System.Windows.Forms.PictureBox pbmor1;
    }
}