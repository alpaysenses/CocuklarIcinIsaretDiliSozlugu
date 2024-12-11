namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Beyaz_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beyaz_İşareti));
            this.pbbeyaz2 = new System.Windows.Forms.PictureBox();
            this.tbbeyazaçıklaması = new System.Windows.Forms.TextBox();
            this.pbbeyaz1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbbeyaz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbeyaz1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbbeyaz2
            // 
            this.pbbeyaz2.Image = ((System.Drawing.Image)(resources.GetObject("pbbeyaz2.Image")));
            this.pbbeyaz2.Location = new System.Drawing.Point(395, 27);
            this.pbbeyaz2.Name = "pbbeyaz2";
            this.pbbeyaz2.Size = new System.Drawing.Size(176, 225);
            this.pbbeyaz2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbeyaz2.TabIndex = 15;
            this.pbbeyaz2.TabStop = false;
            // 
            // tbbeyazaçıklaması
            // 
            this.tbbeyazaçıklaması.Location = new System.Drawing.Point(50, 275);
            this.tbbeyazaçıklaması.Multiline = true;
            this.tbbeyazaçıklaması.Name = "tbbeyazaçıklaması";
            this.tbbeyazaçıklaması.Size = new System.Drawing.Size(550, 44);
            this.tbbeyazaçıklaması.TabIndex = 14;
            this.tbbeyazaçıklaması.Text = "İşaret dilinde beyaz işareti yapabilmek için parmaklarımızı kapatıp elimizi yanağ" +
    "ımıza koyup sonrasında arkaya götürmemiz gerekir.";
            this.tbbeyazaçıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbbeyaz1
            // 
            this.pbbeyaz1.Image = ((System.Drawing.Image)(resources.GetObject("pbbeyaz1.Image")));
            this.pbbeyaz1.Location = new System.Drawing.Point(76, 27);
            this.pbbeyaz1.Name = "pbbeyaz1";
            this.pbbeyaz1.Size = new System.Drawing.Size(176, 225);
            this.pbbeyaz1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbeyaz1.TabIndex = 13;
            this.pbbeyaz1.TabStop = false;
            // 
            // Beyaz_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.pbbeyaz2);
            this.Controls.Add(this.tbbeyazaçıklaması);
            this.Controls.Add(this.pbbeyaz1);
            this.Name = "Beyaz_İşareti";
            this.Text = "Beyaz_İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pbbeyaz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbeyaz1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbbeyaz2;
        private System.Windows.Forms.TextBox tbbeyazaçıklaması;
        private System.Windows.Forms.PictureBox pbbeyaz1;
    }
}