namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    partial class AileKategorisi
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
            this.btkardeş = new System.Windows.Forms.Button();
            this.btdede = new System.Windows.Forms.Button();
            this.btbaba = new System.Windows.Forms.Button();
            this.btanne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btkardeş
            // 
            this.btkardeş.Location = new System.Drawing.Point(72, 252);
            this.btkardeş.Name = "btkardeş";
            this.btkardeş.Size = new System.Drawing.Size(271, 104);
            this.btkardeş.TabIndex = 7;
            this.btkardeş.Text = "KARDEŞ";
            this.btkardeş.UseVisualStyleBackColor = true;
            this.btkardeş.Click += new System.EventHandler(this.btkardeş_Click);
            // 
            // btdede
            // 
            this.btdede.Location = new System.Drawing.Point(425, 252);
            this.btdede.Name = "btdede";
            this.btdede.Size = new System.Drawing.Size(271, 104);
            this.btdede.TabIndex = 6;
            this.btdede.Text = "DEDE";
            this.btdede.UseVisualStyleBackColor = true;
            this.btdede.Click += new System.EventHandler(this.btdede_Click);
            // 
            // btbaba
            // 
            this.btbaba.Location = new System.Drawing.Point(425, 93);
            this.btbaba.Name = "btbaba";
            this.btbaba.Size = new System.Drawing.Size(271, 104);
            this.btbaba.TabIndex = 5;
            this.btbaba.Text = "BABA";
            this.btbaba.UseVisualStyleBackColor = true;
            this.btbaba.Click += new System.EventHandler(this.btbaba_Click);
            // 
            // btanne
            // 
            this.btanne.Location = new System.Drawing.Point(72, 93);
            this.btanne.Name = "btanne";
            this.btanne.Size = new System.Drawing.Size(271, 104);
            this.btanne.TabIndex = 4;
            this.btanne.Text = "ANNE";
            this.btanne.UseVisualStyleBackColor = true;
            this.btanne.Click += new System.EventHandler(this.btanne_Click);
            // 
            // AileKategorisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btkardeş);
            this.Controls.Add(this.btdede);
            this.Controls.Add(this.btbaba);
            this.Controls.Add(this.btanne);
            this.Name = "AileKategorisi";
            this.Text = "AileKategorisi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btkardeş;
        private System.Windows.Forms.Button btdede;
        private System.Windows.Forms.Button btbaba;
        private System.Windows.Forms.Button btanne;
    }
}