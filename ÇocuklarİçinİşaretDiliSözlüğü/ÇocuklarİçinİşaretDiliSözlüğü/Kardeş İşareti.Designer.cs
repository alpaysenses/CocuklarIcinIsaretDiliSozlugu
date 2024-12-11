namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Kardeş_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kardeş_İşareti));
            this.pbkardeş2 = new System.Windows.Forms.PictureBox();
            this.tbkardeşaçıklaması = new System.Windows.Forms.TextBox();
            this.pbkardeş1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbkardeş2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbkardeş1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbkardeş2
            // 
            this.pbkardeş2.Image = ((System.Drawing.Image)(resources.GetObject("pbkardeş2.Image")));
            this.pbkardeş2.Location = new System.Drawing.Point(395, 28);
            this.pbkardeş2.Name = "pbkardeş2";
            this.pbkardeş2.Size = new System.Drawing.Size(176, 225);
            this.pbkardeş2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbkardeş2.TabIndex = 6;
            this.pbkardeş2.TabStop = false;
            // 
            // tbkardeşaçıklaması
            // 
            this.tbkardeşaçıklaması.Location = new System.Drawing.Point(50, 276);
            this.tbkardeşaçıklaması.Multiline = true;
            this.tbkardeşaçıklaması.Name = "tbkardeşaçıklaması";
            this.tbkardeşaçıklaması.Size = new System.Drawing.Size(550, 44);
            this.tbkardeşaçıklaması.TabIndex = 5;
            this.tbkardeşaçıklaması.Text = "İşaret dilinde kardeş işareti yapabilmek için iki elimizi yumruk şeklinde tutup s" +
    "erçe parmakların açıp birbirine değdirilmemiz gerekir.";
            this.tbkardeşaçıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbkardeş1
            // 
            this.pbkardeş1.Image = ((System.Drawing.Image)(resources.GetObject("pbkardeş1.Image")));
            this.pbkardeş1.Location = new System.Drawing.Point(97, 28);
            this.pbkardeş1.Name = "pbkardeş1";
            this.pbkardeş1.Size = new System.Drawing.Size(176, 225);
            this.pbkardeş1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbkardeş1.TabIndex = 4;
            this.pbkardeş1.TabStop = false;
            // 
            // Kardeş_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.pbkardeş2);
            this.Controls.Add(this.tbkardeşaçıklaması);
            this.Controls.Add(this.pbkardeş1);
            this.Name = "Kardeş_İşareti";
            this.Text = "Kardeş İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pbkardeş2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbkardeş1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbkardeş2;
        private System.Windows.Forms.TextBox tbkardeşaçıklaması;
        private System.Windows.Forms.PictureBox pbkardeş1;
    }
}