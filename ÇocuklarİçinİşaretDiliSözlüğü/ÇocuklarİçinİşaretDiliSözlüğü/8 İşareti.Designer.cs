namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class _8_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_8_İşareti));
            this.tb8açıklaması = new System.Windows.Forms.TextBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            this.SuspendLayout();
            // 
            // tb8açıklaması
            // 
            this.tb8açıklaması.Location = new System.Drawing.Point(50, 291);
            this.tb8açıklaması.Multiline = true;
            this.tb8açıklaması.Name = "tb8açıklaması";
            this.tb8açıklaması.Size = new System.Drawing.Size(550, 44);
            this.tb8açıklaması.TabIndex = 7;
            this.tb8açıklaması.Text = "İşaret dilinde 8 işareti yapabilmek için elimizi yumruk şekline getirip işaret ve" +
    " orta parmaklarımızı aşağıya doğru bürkmemiz gerekir.";
            this.tb8açıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb8
            // 
            this.pb8.Image = ((System.Drawing.Image)(resources.GetObject("pb8.Image")));
            this.pb8.Location = new System.Drawing.Point(222, 12);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(193, 256);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 6;
            this.pb8.TabStop = false;
            // 
            // _8_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.tb8açıklaması);
            this.Controls.Add(this.pb8);
            this.Name = "_8_İşareti";
            this.Text = "8 İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb8açıklaması;
        private System.Windows.Forms.PictureBox pb8;
    }
}