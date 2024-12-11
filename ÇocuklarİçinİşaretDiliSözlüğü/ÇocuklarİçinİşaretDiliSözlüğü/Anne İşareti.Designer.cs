namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Anne_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anne_İşareti));
            this.pbanne1 = new System.Windows.Forms.PictureBox();
            this.tbanneaçıklaması = new System.Windows.Forms.TextBox();
            this.pbanne2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbanne1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanne2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbanne1
            // 
            this.pbanne1.Image = ((System.Drawing.Image)(resources.GetObject("pbanne1.Image")));
            this.pbanne1.Location = new System.Drawing.Point(94, 24);
            this.pbanne1.Name = "pbanne1";
            this.pbanne1.Size = new System.Drawing.Size(176, 225);
            this.pbanne1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbanne1.TabIndex = 0;
            this.pbanne1.TabStop = false;
            // 
            // tbanneaçıklaması
            // 
            this.tbanneaçıklaması.Location = new System.Drawing.Point(52, 273);
            this.tbanneaçıklaması.Multiline = true;
            this.tbanneaçıklaması.Name = "tbanneaçıklaması";
            this.tbanneaçıklaması.Size = new System.Drawing.Size(550, 44);
            this.tbanneaçıklaması.TabIndex = 2;
            this.tbanneaçıklaması.Text = "İşaret dilinde anne işareti yapabilmek için avucumuzu sağ göğüsümüzden sol göğüsü" +
    "müze tutmamız gerekir.";
            this.tbanneaçıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbanne2
            // 
            this.pbanne2.Image = ((System.Drawing.Image)(resources.GetObject("pbanne2.Image")));
            this.pbanne2.Location = new System.Drawing.Point(392, 24);
            this.pbanne2.Name = "pbanne2";
            this.pbanne2.Size = new System.Drawing.Size(176, 225);
            this.pbanne2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbanne2.TabIndex = 3;
            this.pbanne2.TabStop = false;
            // 
            // Anne_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.pbanne2);
            this.Controls.Add(this.tbanneaçıklaması);
            this.Controls.Add(this.pbanne1);
            this.Name = "Anne_İşareti";
            this.Text = "Anne İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pbanne1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanne2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbanne1;
        private System.Windows.Forms.TextBox tbanneaçıklaması;
        private System.Windows.Forms.PictureBox pbanne2;
    }
}