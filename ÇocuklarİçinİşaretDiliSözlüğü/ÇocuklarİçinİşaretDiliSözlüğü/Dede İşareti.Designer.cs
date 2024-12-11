namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Dede_İşareti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dede_İşareti));
            this.pbdede2 = new System.Windows.Forms.PictureBox();
            this.tbdedeaçıklaması = new System.Windows.Forms.TextBox();
            this.pbdede1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbdede2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdede1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbdede2
            // 
            this.pbdede2.Image = ((System.Drawing.Image)(resources.GetObject("pbdede2.Image")));
            this.pbdede2.Location = new System.Drawing.Point(395, 27);
            this.pbdede2.Name = "pbdede2";
            this.pbdede2.Size = new System.Drawing.Size(176, 225);
            this.pbdede2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdede2.TabIndex = 9;
            this.pbdede2.TabStop = false;
            // 
            // tbdedeaçıklaması
            // 
            this.tbdedeaçıklaması.Location = new System.Drawing.Point(50, 275);
            this.tbdedeaçıklaması.Multiline = true;
            this.tbdedeaçıklaması.Name = "tbdedeaçıklaması";
            this.tbdedeaçıklaması.Size = new System.Drawing.Size(550, 44);
            this.tbdedeaçıklaması.TabIndex = 8;
            this.tbdedeaçıklaması.Text = "İşaret dilinde dede işareti yapabilmek için elimizin üstünü çeneye tutup baş parm" +
    "ak dışındaki parmakları açıp kapamamız gerekir.";
            this.tbdedeaçıklaması.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbdede1
            // 
            this.pbdede1.Image = ((System.Drawing.Image)(resources.GetObject("pbdede1.Image")));
            this.pbdede1.Location = new System.Drawing.Point(76, 27);
            this.pbdede1.Name = "pbdede1";
            this.pbdede1.Size = new System.Drawing.Size(176, 225);
            this.pbdede1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdede1.TabIndex = 7;
            this.pbdede1.TabStop = false;
            // 
            // Dede_İşareti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 347);
            this.Controls.Add(this.pbdede2);
            this.Controls.Add(this.tbdedeaçıklaması);
            this.Controls.Add(this.pbdede1);
            this.Name = "Dede_İşareti";
            this.Text = "Dede İşareti";
            ((System.ComponentModel.ISupportInitialize)(this.pbdede2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdede1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbdede2;
        private System.Windows.Forms.TextBox tbdedeaçıklaması;
        private System.Windows.Forms.PictureBox pbdede1;
    }
}