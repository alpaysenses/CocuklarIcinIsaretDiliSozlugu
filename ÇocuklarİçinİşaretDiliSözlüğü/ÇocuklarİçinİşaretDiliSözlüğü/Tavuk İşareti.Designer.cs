namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Tavuk_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tavuk_İşareti));
            this.pbtavuk2 = new System.Windows.Forms.PictureBox();
            this.tbtavukaçıklaması = new System.Windows.Forms.TextBox();
            this.pbtavuk1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbtavuk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtavuk1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbtavuk2
            // 
            this.pbtavuk2.Image = ((System.Drawing.Image)(resources.GetObject("pbtavuk2.Image")));
            this.pbtavuk2.Location = new System.Drawing.Point(395, 27);
            this.pbtavuk2.Name = "pbtavuk2";
            this.pbtavuk2.Size = new System.Drawing.Size(176, 225);
            this.pbtavuk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtavuk2.TabIndex = 24;
            this.pbtavuk2.TabStop = false;
            // 
            // tbtavukaçıklaması
            // 
            this.tbtavukaçıklaması.Location = new System.Drawing.Point(50, 275);
            this.tbtavukaçıklaması.Multiline = true;
            this.tbtavukaçıklaması.Name = "tbtavukaçıklaması";
            this.tbtavukaçıklaması.Size = new System.Drawing.Size(550, 44);
            this.tbtavukaçıklaması.TabIndex = 23;
            this.tbtavukaçıklaması.Text = "İşaret dilinde tavuk işareti yapabilmek için  sol elimizin avuç içini açıp sağ iş" +
    "aret parmağımızı avuç içine dokundurup çekmemiz gerekir.";
            this.tbtavukaçıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbtavuk1
            // 
            this.pbtavuk1.Image = ((System.Drawing.Image)(resources.GetObject("pbtavuk1.Image")));
            this.pbtavuk1.Location = new System.Drawing.Point(76, 27);
            this.pbtavuk1.Name = "pbtavuk1";
            this.pbtavuk1.Size = new System.Drawing.Size(176, 225);
            this.pbtavuk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtavuk1.TabIndex = 22;
            this.pbtavuk1.TabStop = false;
            // 
            // Tavuk_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.pbtavuk2);
            this.Controls.Add(this.tbtavukaçıklaması);
            this.Controls.Add(this.pbtavuk1);
            this.Name = "Tavuk_İşareti";
            this.Text = "Tavuk İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pbtavuk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtavuk1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbtavuk2;
        private System.Windows.Forms.TextBox tbtavukaçıklaması;
        private System.Windows.Forms.PictureBox pbtavuk1;
    }
}