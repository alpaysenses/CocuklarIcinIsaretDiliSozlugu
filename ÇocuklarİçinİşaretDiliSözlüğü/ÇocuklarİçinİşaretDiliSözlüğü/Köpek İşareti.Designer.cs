namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Köpek_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Köpek_İşareti));
            this.pbköpek2 = new System.Windows.Forms.PictureBox();
            this.tbköpekaçıklaması = new System.Windows.Forms.TextBox();
            this.pbköpek1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbköpek2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbköpek1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbköpek2
            // 
            this.pbköpek2.Image = ((System.Drawing.Image)(resources.GetObject("pbköpek2.Image")));
            this.pbköpek2.Location = new System.Drawing.Point(395, 27);
            this.pbköpek2.Name = "pbköpek2";
            this.pbköpek2.Size = new System.Drawing.Size(176, 225);
            this.pbköpek2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbköpek2.TabIndex = 24;
            this.pbköpek2.TabStop = false;
            // 
            // tbköpekaçıklaması
            // 
            this.tbköpekaçıklaması.Location = new System.Drawing.Point(50, 275);
            this.tbköpekaçıklaması.Multiline = true;
            this.tbköpekaçıklaması.Name = "tbköpekaçıklaması";
            this.tbköpekaçıklaması.Size = new System.Drawing.Size(550, 44);
            this.tbköpekaçıklaması.TabIndex = 23;
            this.tbköpekaçıklaması.Text = "İşaret dilinde köpek işareti yapabilmek için sol elimizin parmak uçlarını büküp  " +
    "aşağıda tuttuktan sonra sağ elimizi sol elimizin üstüne alıp sağ elimizi yukarıd" +
    "an aşağıya indirmemiz gerekir.";
            this.tbköpekaçıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbköpek1
            // 
            this.pbköpek1.Image = ((System.Drawing.Image)(resources.GetObject("pbköpek1.Image")));
            this.pbköpek1.Location = new System.Drawing.Point(76, 27);
            this.pbköpek1.Name = "pbköpek1";
            this.pbköpek1.Size = new System.Drawing.Size(176, 225);
            this.pbköpek1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbköpek1.TabIndex = 22;
            this.pbköpek1.TabStop = false;
            // 
            // Köpek_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.pbköpek2);
            this.Controls.Add(this.tbköpekaçıklaması);
            this.Controls.Add(this.pbköpek1);
            this.Name = "Köpek_İşareti";
            this.Text = "Köpek İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pbköpek2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbköpek1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbköpek2;
        private System.Windows.Forms.TextBox tbköpekaçıklaması;
        private System.Windows.Forms.PictureBox pbköpek1;
    }
}