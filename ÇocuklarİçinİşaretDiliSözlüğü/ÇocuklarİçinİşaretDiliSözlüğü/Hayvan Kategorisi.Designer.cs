namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class Hayvan_Kategorisi
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
            this.bttavuk = new System.Windows.Forms.Button();
            this.btkuş = new System.Windows.Forms.Button();
            this.bteşşek = new System.Windows.Forms.Button();
            this.btköpek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttavuk
            // 
            this.bttavuk.Location = new System.Drawing.Point(88, 253);
            this.bttavuk.Name = "bttavuk";
            this.bttavuk.Size = new System.Drawing.Size(271, 104);
            this.bttavuk.TabIndex = 11;
            this.bttavuk.Text = "TAVUK";
            this.bttavuk.UseVisualStyleBackColor = true;
            this.bttavuk.Click += new System.EventHandler(this.bttavuk_Click);
            // 
            // btkuş
            // 
            this.btkuş.Location = new System.Drawing.Point(441, 253);
            this.btkuş.Name = "btkuş";
            this.btkuş.Size = new System.Drawing.Size(271, 104);
            this.btkuş.TabIndex = 10;
            this.btkuş.Text = "KUŞ";
            this.btkuş.UseVisualStyleBackColor = true;
            this.btkuş.Click += new System.EventHandler(this.btkuş_Click);
            // 
            // bteşşek
            // 
            this.bteşşek.Location = new System.Drawing.Point(441, 94);
            this.bteşşek.Name = "bteşşek";
            this.bteşşek.Size = new System.Drawing.Size(271, 104);
            this.bteşşek.TabIndex = 9;
            this.bteşşek.Text = "EŞEK";
            this.bteşşek.UseVisualStyleBackColor = true;
            this.bteşşek.Click += new System.EventHandler(this.bteşşek_Click);
            // 
            // btköpek
            // 
            this.btköpek.Location = new System.Drawing.Point(88, 94);
            this.btköpek.Name = "btköpek";
            this.btköpek.Size = new System.Drawing.Size(271, 104);
            this.btköpek.TabIndex = 8;
            this.btköpek.Text = "KÖPEK";
            this.btköpek.UseVisualStyleBackColor = true;
            this.btköpek.Click += new System.EventHandler(this.btköpek_Click);
            // 
            // Hayvan_Kategorisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttavuk);
            this.Controls.Add(this.btkuş);
            this.Controls.Add(this.bteşşek);
            this.Controls.Add(this.btköpek);
            this.Name = "Hayvan_Kategorisi";
            this.Text = "Hayvan Kategorisi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttavuk;
        private System.Windows.Forms.Button btkuş;
        private System.Windows.Forms.Button bteşşek;
        private System.Windows.Forms.Button btköpek;
    }
}