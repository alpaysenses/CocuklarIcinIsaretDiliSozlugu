namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Form1
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
            this.btaile = new System.Windows.Forms.Button();
            this.btrenk = new System.Windows.Forms.Button();
            this.bthayvan = new System.Windows.Forms.Button();
            this.btsayı = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btaile
            // 
            this.btaile.Location = new System.Drawing.Point(80, 94);
            this.btaile.Name = "btaile";
            this.btaile.Size = new System.Drawing.Size(271, 104);
            this.btaile.TabIndex = 0;
            this.btaile.Text = "AİLE";
            this.btaile.UseVisualStyleBackColor = true;
            this.btaile.Click += new System.EventHandler(this.btaile_Click);
            // 
            // btrenk
            // 
            this.btrenk.Location = new System.Drawing.Point(433, 94);
            this.btrenk.Name = "btrenk";
            this.btrenk.Size = new System.Drawing.Size(271, 104);
            this.btrenk.TabIndex = 1;
            this.btrenk.Text = "RENK";
            this.btrenk.UseVisualStyleBackColor = true;
            this.btrenk.Click += new System.EventHandler(this.btrenk_Click);
            // 
            // bthayvan
            // 
            this.bthayvan.Location = new System.Drawing.Point(80, 253);
            this.bthayvan.Name = "bthayvan";
            this.bthayvan.Size = new System.Drawing.Size(271, 104);
            this.bthayvan.TabIndex = 3;
            this.bthayvan.Text = "HAYVAN";
            this.bthayvan.UseVisualStyleBackColor = true;
            this.bthayvan.Click += new System.EventHandler(this.bthayvan_Click);
            // 
            // btsayı
            // 
            this.btsayı.Location = new System.Drawing.Point(433, 253);
            this.btsayı.Name = "btsayı";
            this.btsayı.Size = new System.Drawing.Size(271, 104);
            this.btsayı.TabIndex = 2;
            this.btsayı.Text = "SAYI";
            this.btsayı.UseVisualStyleBackColor = true;
            this.btsayı.Click += new System.EventHandler(this.btsayı_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bthayvan);
            this.Controls.Add(this.btsayı);
            this.Controls.Add(this.btrenk);
            this.Controls.Add(this.btaile);
            this.Name = "Form1";
            this.Text = "Kategori Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btaile;
        private System.Windows.Forms.Button btrenk;
        private System.Windows.Forms.Button bthayvan;
        private System.Windows.Forms.Button btsayı;
    }
}

