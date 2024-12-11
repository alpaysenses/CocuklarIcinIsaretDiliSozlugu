namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Baba_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baba_İşareti));
            this.tbbabaaçıklaması = new System.Windows.Forms.TextBox();
            this.pbbaba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbbaba)).BeginInit();
            this.SuspendLayout();
            // 
            // tbbabaaçıklaması
            // 
            this.tbbabaaçıklaması.Location = new System.Drawing.Point(54, 291);
            this.tbbabaaçıklaması.Multiline = true;
            this.tbbabaaçıklaması.Name = "tbbabaaçıklaması";
            this.tbbabaaçıklaması.Size = new System.Drawing.Size(550, 44);
            this.tbbabaaçıklaması.TabIndex = 5;
            this.tbbabaaçıklaması.Text = "İşaret dilinde baba işareti yapabilmek için baş parmağımızı çenemize tutmamız ger" +
    "ekir.";
            this.tbbabaaçıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbbaba
            // 
            this.pbbaba.Image = ((System.Drawing.Image)(resources.GetObject("pbbaba.Image")));
            this.pbbaba.Location = new System.Drawing.Point(226, 12);
            this.pbbaba.Name = "pbbaba";
            this.pbbaba.Size = new System.Drawing.Size(193, 256);
            this.pbbaba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbaba.TabIndex = 4;
            this.pbbaba.TabStop = false;
            // 
            // Baba_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.tbbabaaçıklaması);
            this.Controls.Add(this.pbbaba);
            this.Name = "Baba_İşareti";
            this.Text = "Baba İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pbbaba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbbabaaçıklaması;
        private System.Windows.Forms.PictureBox pbbaba;
    }
}