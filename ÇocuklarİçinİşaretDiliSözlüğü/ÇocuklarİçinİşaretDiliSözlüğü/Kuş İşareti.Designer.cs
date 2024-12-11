namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Kuş_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kuş_İşareti));
            this.pbkuş2 = new System.Windows.Forms.PictureBox();
            this.tbkuşaçıklaması = new System.Windows.Forms.TextBox();
            this.pbkuş1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbkuş2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbkuş1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbkuş2
            // 
            this.pbkuş2.Image = ((System.Drawing.Image)(resources.GetObject("pbkuş2.Image")));
            this.pbkuş2.Location = new System.Drawing.Point(395, 27);
            this.pbkuş2.Name = "pbkuş2";
            this.pbkuş2.Size = new System.Drawing.Size(176, 225);
            this.pbkuş2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbkuş2.TabIndex = 24;
            this.pbkuş2.TabStop = false;
            // 
            // tbkuşaçıklaması
            // 
            this.tbkuşaçıklaması.Location = new System.Drawing.Point(50, 275);
            this.tbkuşaçıklaması.Multiline = true;
            this.tbkuşaçıklaması.Name = "tbkuşaçıklaması";
            this.tbkuşaçıklaması.Size = new System.Drawing.Size(550, 44);
            this.tbkuşaçıklaması.TabIndex = 23;
            this.tbkuşaçıklaması.Text = "İşaret dilinde kuş işareti yapabilmek için  kollarımızı dirsekten büküp yan taraf" +
    "larımıza aldıktan sonra aşağıya doğru indirmemiz gerekir.";
            this.tbkuşaçıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbkuş1
            // 
            this.pbkuş1.Image = ((System.Drawing.Image)(resources.GetObject("pbkuş1.Image")));
            this.pbkuş1.Location = new System.Drawing.Point(76, 27);
            this.pbkuş1.Name = "pbkuş1";
            this.pbkuş1.Size = new System.Drawing.Size(176, 225);
            this.pbkuş1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbkuş1.TabIndex = 22;
            this.pbkuş1.TabStop = false;
            // 
            // Kuş_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.pbkuş2);
            this.Controls.Add(this.tbkuşaçıklaması);
            this.Controls.Add(this.pbkuş1);
            this.Name = "Kuş_İşareti";
            this.Text = "Kuş İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pbkuş2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbkuş1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbkuş2;
        private System.Windows.Forms.TextBox tbkuşaçıklaması;
        private System.Windows.Forms.PictureBox pbkuş1;
    }
}