namespace dersÖrnekKDVHesaplama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.rBtn1 = new System.Windows.Forms.RadioButton();
            this.rBtn8 = new System.Windows.Forms.RadioButton();
            this.rBtn18 = new System.Windows.Forms.RadioButton();
            this.txtKdvTutar = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adedi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "KDV Oranı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "KDV Tutarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toplam Tutar:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(116, 19);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(73, 22);
            this.txtFiyat.TabIndex = 5;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(116, 58);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(73, 22);
            this.txtAdet.TabIndex = 6;
            // 
            // rBtn1
            // 
            this.rBtn1.AutoSize = true;
            this.rBtn1.Location = new System.Drawing.Point(120, 97);
            this.rBtn1.Name = "rBtn1";
            this.rBtn1.Size = new System.Drawing.Size(49, 21);
            this.rBtn1.TabIndex = 7;
            this.rBtn1.TabStop = true;
            this.rBtn1.Text = "1%";
            this.rBtn1.UseVisualStyleBackColor = true;
            // 
            // rBtn8
            // 
            this.rBtn8.AutoSize = true;
            this.rBtn8.Location = new System.Drawing.Point(175, 97);
            this.rBtn8.Name = "rBtn8";
            this.rBtn8.Size = new System.Drawing.Size(49, 21);
            this.rBtn8.TabIndex = 8;
            this.rBtn8.TabStop = true;
            this.rBtn8.Text = "8%";
            this.rBtn8.UseVisualStyleBackColor = true;
            // 
            // rBtn18
            // 
            this.rBtn18.AutoSize = true;
            this.rBtn18.Location = new System.Drawing.Point(230, 97);
            this.rBtn18.Name = "rBtn18";
            this.rBtn18.Size = new System.Drawing.Size(57, 21);
            this.rBtn18.TabIndex = 9;
            this.rBtn18.TabStop = true;
            this.rBtn18.Text = "18%";
            this.rBtn18.UseVisualStyleBackColor = true;
            // 
            // txtKdvTutar
            // 
            this.txtKdvTutar.Location = new System.Drawing.Point(116, 137);
            this.txtKdvTutar.Name = "txtKdvTutar";
            this.txtKdvTutar.Size = new System.Drawing.Size(73, 22);
            this.txtKdvTutar.TabIndex = 10;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(116, 235);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(73, 22);
            this.txtToplamTutar.TabIndex = 11;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(116, 177);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(73, 42);
            this.btnHesapla.TabIndex = 12;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 303);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtKdvTutar);
            this.Controls.Add(this.rBtn18);
            this.Controls.Add(this.rBtn8);
            this.Controls.Add(this.rBtn1);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.RadioButton rBtn1;
        private System.Windows.Forms.RadioButton rBtn8;
        private System.Windows.Forms.RadioButton rBtn18;
        private System.Windows.Forms.TextBox txtKdvTutar;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Button btnHesapla;
    }
}

