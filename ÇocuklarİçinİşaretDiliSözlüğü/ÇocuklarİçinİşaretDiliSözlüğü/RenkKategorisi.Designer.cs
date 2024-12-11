namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class RenkKategorisi
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
            this.btpembe = new System.Windows.Forms.Button();
            this.btmor = new System.Windows.Forms.Button();
            this.btbeyaz = new System.Windows.Forms.Button();
            this.btsiyah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btpembe
            // 
            this.btpembe.Location = new System.Drawing.Point(88, 253);
            this.btpembe.Name = "btpembe";
            this.btpembe.Size = new System.Drawing.Size(271, 104);
            this.btpembe.TabIndex = 7;
            this.btpembe.Text = "PEMBE";
            this.btpembe.UseVisualStyleBackColor = true;
            this.btpembe.Click += new System.EventHandler(this.btpembe_Click);
            // 
            // btmor
            // 
            this.btmor.Location = new System.Drawing.Point(441, 253);
            this.btmor.Name = "btmor";
            this.btmor.Size = new System.Drawing.Size(271, 104);
            this.btmor.TabIndex = 6;
            this.btmor.Text = "MOR";
            this.btmor.UseVisualStyleBackColor = true;
            this.btmor.Click += new System.EventHandler(this.btmor_Click);
            // 
            // btbeyaz
            // 
            this.btbeyaz.Location = new System.Drawing.Point(441, 94);
            this.btbeyaz.Name = "btbeyaz";
            this.btbeyaz.Size = new System.Drawing.Size(271, 104);
            this.btbeyaz.TabIndex = 5;
            this.btbeyaz.Text = "BEYAZ";
            this.btbeyaz.UseVisualStyleBackColor = true;
            this.btbeyaz.Click += new System.EventHandler(this.btbeyaz_Click);
            // 
            // btsiyah
            // 
            this.btsiyah.Location = new System.Drawing.Point(88, 94);
            this.btsiyah.Name = "btsiyah";
            this.btsiyah.Size = new System.Drawing.Size(271, 104);
            this.btsiyah.TabIndex = 4;
            this.btsiyah.Text = "SİYAH";
            this.btsiyah.UseVisualStyleBackColor = true;
            this.btsiyah.Click += new System.EventHandler(this.btsiyah_Click);
            // 
            // RenkKategorisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btpembe);
            this.Controls.Add(this.btmor);
            this.Controls.Add(this.btbeyaz);
            this.Controls.Add(this.btsiyah);
            this.Name = "RenkKategorisi";
            this.Text = "RenkKategorisi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btpembe;
        private System.Windows.Forms.Button btmor;
        private System.Windows.Forms.Button btbeyaz;
        private System.Windows.Forms.Button btsiyah;
    }
}