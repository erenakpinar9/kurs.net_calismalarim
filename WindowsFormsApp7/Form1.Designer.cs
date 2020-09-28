namespace WindowsFormsApp7
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
            this.lblS1 = new System.Windows.Forms.Label();
            this.lblS2 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Location = new System.Drawing.Point(29, 26);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(51, 17);
            this.lblS1.TabIndex = 0;
            this.lblS1.Text = "Sayı 1:";
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.Location = new System.Drawing.Point(29, 61);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(51, 17);
            this.lblS2.TabIndex = 1;
            this.lblS2.Text = "Sayı 2:";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(86, 26);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(100, 22);
            this.txtS1.TabIndex = 2;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(86, 61);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(100, 22);
            this.txtS2.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(106, 99);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(80, 36);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(86, 160);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 22);
            this.txtSonuc.TabIndex = 5;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(29, 163);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(52, 17);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(111, 198);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 260);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.lblS2);
            this.Controls.Add(this.lblS1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.Label lblS2;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnTemizle;
    }
}

