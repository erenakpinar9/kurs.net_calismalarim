namespace HesapMakinesi_Çakma_
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
            this.chbTopla = new System.Windows.Forms.CheckBox();
            this.chbCikar = new System.Windows.Forms.CheckBox();
            this.chbCarp = new System.Windows.Forms.CheckBox();
            this.chbBol = new System.Windows.Forms.CheckBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.Sonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Location = new System.Drawing.Point(37, 24);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(51, 17);
            this.lblS1.TabIndex = 0;
            this.lblS1.Text = "Sayı 1:";
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.Location = new System.Drawing.Point(37, 67);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(51, 17);
            this.lblS2.TabIndex = 1;
            this.lblS2.Text = "Sayı 2:";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(89, 22);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(100, 22);
            this.txtS1.TabIndex = 2;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(89, 64);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(100, 22);
            this.txtS2.TabIndex = 3;
            // 
            // chbTopla
            // 
            this.chbTopla.AutoSize = true;
            this.chbTopla.Location = new System.Drawing.Point(228, 20);
            this.chbTopla.Name = "chbTopla";
            this.chbTopla.Size = new System.Drawing.Size(66, 21);
            this.chbTopla.TabIndex = 4;
            this.chbTopla.Text = "Topla";
            this.chbTopla.UseVisualStyleBackColor = true;
            // 
            // chbCikar
            // 
            this.chbCikar.AutoSize = true;
            this.chbCikar.Location = new System.Drawing.Point(228, 47);
            this.chbCikar.Name = "chbCikar";
            this.chbCikar.Size = new System.Drawing.Size(62, 21);
            this.chbCikar.TabIndex = 5;
            this.chbCikar.Text = "Çıkar";
            this.chbCikar.UseVisualStyleBackColor = true;
            // 
            // chbCarp
            // 
            this.chbCarp.AutoSize = true;
            this.chbCarp.Location = new System.Drawing.Point(228, 74);
            this.chbCarp.Name = "chbCarp";
            this.chbCarp.Size = new System.Drawing.Size(60, 21);
            this.chbCarp.TabIndex = 6;
            this.chbCarp.Text = "Çarp";
            this.chbCarp.UseVisualStyleBackColor = true;
            // 
            // chbBol
            // 
            this.chbBol.AutoSize = true;
            this.chbBol.Location = new System.Drawing.Point(228, 101);
            this.chbBol.Name = "chbBol";
            this.chbBol.Size = new System.Drawing.Size(50, 21);
            this.chbBol.TabIndex = 7;
            this.chbBol.Text = "Böl";
            this.chbBol.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(228, 145);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 30);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(228, 181);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 30);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Sonuc
            // 
            this.Sonuc.FormattingEnabled = true;
            this.Sonuc.ItemHeight = 16;
            this.Sonuc.Location = new System.Drawing.Point(40, 127);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(149, 84);
            this.Sonuc.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 239);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.chbBol);
            this.Controls.Add(this.chbCarp);
            this.Controls.Add(this.chbCikar);
            this.Controls.Add(this.chbTopla);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.lblS2);
            this.Controls.Add(this.lblS1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.Label lblS2;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.CheckBox chbTopla;
        private System.Windows.Forms.CheckBox chbCikar;
        private System.Windows.Forms.CheckBox chbCarp;
        private System.Windows.Forms.CheckBox chbBol;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox Sonuc;
    }
}

