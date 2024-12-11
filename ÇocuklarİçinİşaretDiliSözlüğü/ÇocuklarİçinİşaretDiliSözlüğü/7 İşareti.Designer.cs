namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class _7_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_7_İşareti));
            this.tb7açıklaması = new System.Windows.Forms.TextBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            this.SuspendLayout();
            // 
            // tb7açıklaması
            // 
            this.tb7açıklaması.Location = new System.Drawing.Point(50, 291);
            this.tb7açıklaması.Multiline = true;
            this.tb7açıklaması.Name = "tb7açıklaması";
            this.tb7açıklaması.Size = new System.Drawing.Size(550, 44);
            this.tb7açıklaması.TabIndex = 7;
            this.tb7açıklaması.Text = "İşaret dilinde 7 işareti yapabilmek için elimizi yumruk şekline getirip işaret ve" +
    " orta parmağımızı yukarıya doğru bürkmemiz gerekir.";
            this.tb7açıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb7
            // 
            this.pb7.Image = ((System.Drawing.Image)(resources.GetObject("pb7.Image")));
            this.pb7.Location = new System.Drawing.Point(222, 12);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(193, 256);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 6;
            this.pb7.TabStop = false;
            // 
            // _7_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.tb7açıklaması);
            this.Controls.Add(this.pb7);
            this.Name = "_7_İşareti";
            this.Text = "7 İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb7açıklaması;
        private System.Windows.Forms.PictureBox pb7;
    }
}