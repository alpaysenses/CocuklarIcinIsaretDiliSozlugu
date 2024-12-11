namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Pembe_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembe_İşareti));
            this.pbpembe2 = new System.Windows.Forms.PictureBox();
            this.tbpembeaçıklaması = new System.Windows.Forms.TextBox();
            this.pbpembe1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbpembe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpembe1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbpembe2
            // 
            this.pbpembe2.Image = ((System.Drawing.Image)(resources.GetObject("pbpembe2.Image")));
            this.pbpembe2.Location = new System.Drawing.Point(395, 27);
            this.pbpembe2.Name = "pbpembe2";
            this.pbpembe2.Size = new System.Drawing.Size(176, 225);
            this.pbpembe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpembe2.TabIndex = 18;
            this.pbpembe2.TabStop = false;
            // 
            // tbpembeaçıklaması
            // 
            this.tbpembeaçıklaması.Location = new System.Drawing.Point(50, 275);
            this.tbpembeaçıklaması.Multiline = true;
            this.tbpembeaçıklaması.Name = "tbpembeaçıklaması";
            this.tbpembeaçıklaması.Size = new System.Drawing.Size(550, 44);
            this.tbpembeaçıklaması.TabIndex = 17;
            this.tbpembeaçıklaması.Text = "İşaret dilinde pembe işareti yapabilmek için elimizi yanağımıza dokundurup geri ç" +
    "ekmemiz gerekir.";
            this.tbpembeaçıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbpembe1
            // 
            this.pbpembe1.Image = ((System.Drawing.Image)(resources.GetObject("pbpembe1.Image")));
            this.pbpembe1.Location = new System.Drawing.Point(76, 27);
            this.pbpembe1.Name = "pbpembe1";
            this.pbpembe1.Size = new System.Drawing.Size(176, 225);
            this.pbpembe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpembe1.TabIndex = 16;
            this.pbpembe1.TabStop = false;
            // 
            // Pembe_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.pbpembe2);
            this.Controls.Add(this.tbpembeaçıklaması);
            this.Controls.Add(this.pbpembe1);
            this.Name = "Pembe_İşareti";
            this.Text = "Pembe İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pbpembe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpembe1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbpembe2;
        private System.Windows.Forms.TextBox tbpembeaçıklaması;
        private System.Windows.Forms.PictureBox pbpembe1;
    }
}