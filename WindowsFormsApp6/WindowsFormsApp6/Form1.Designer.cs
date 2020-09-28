namespace WindowsFormsApp6
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
            this.txtGonderici = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtHayir = new System.Windows.Forms.RadioButton();
            this.rbtEvet = new System.Windows.Forms.RadioButton();
            this.txtDerinlik = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtAgirlik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMesafe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblGonderici = new System.Windows.Forms.Label();
            this.Bilgiler = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.Bilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gönderici:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon:";
            // 
            // txtGonderici
            // 
            this.txtGonderici.Location = new System.Drawing.Point(91, 42);
            this.txtGonderici.Name = "txtGonderici";
            this.txtGonderici.Size = new System.Drawing.Size(125, 22);
            this.txtGonderici.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(91, 72);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(125, 22);
            this.txtTelefon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yükün Ağırlığı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtHayir);
            this.groupBox1.Controls.Add(this.rbtEvet);
            this.groupBox1.Controls.Add(this.txtDerinlik);
            this.groupBox1.Controls.Add(this.txtBoy);
            this.groupBox1.Controls.Add(this.txtEn);
            this.groupBox1.Controls.Add(this.txtAgirlik);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 189);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yük";
            // 
            // rbtHayir
            // 
            this.rbtHayir.AutoSize = true;
            this.rbtHayir.Location = new System.Drawing.Point(139, 146);
            this.rbtHayir.Name = "rbtHayir";
            this.rbtHayir.Size = new System.Drawing.Size(62, 21);
            this.rbtHayir.TabIndex = 13;
            this.rbtHayir.TabStop = true;
            this.rbtHayir.Text = "Hayır";
            this.rbtHayir.UseVisualStyleBackColor = true;
            // 
            // rbtEvet
            // 
            this.rbtEvet.AutoSize = true;
            this.rbtEvet.Location = new System.Drawing.Point(76, 146);
            this.rbtEvet.Name = "rbtEvet";
            this.rbtEvet.Size = new System.Drawing.Size(57, 21);
            this.rbtEvet.TabIndex = 12;
            this.rbtEvet.TabStop = true;
            this.rbtEvet.Text = "Evet";
            this.rbtEvet.UseVisualStyleBackColor = true;
            this.rbtEvet.CheckedChanged += new System.EventHandler(this.rbtEvet_CheckedChanged);
            // 
            // txtDerinlik
            // 
            this.txtDerinlik.Location = new System.Drawing.Point(114, 112);
            this.txtDerinlik.Name = "txtDerinlik";
            this.txtDerinlik.Size = new System.Drawing.Size(100, 22);
            this.txtDerinlik.TabIndex = 11;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(114, 84);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(100, 22);
            this.txtBoy.TabIndex = 10;
            // 
            // txtEn
            // 
            this.txtEn.Location = new System.Drawing.Point(114, 56);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(100, 22);
            this.txtEn.TabIndex = 9;
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.Location = new System.Drawing.Point(114, 28);
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.Size = new System.Drawing.Size(100, 22);
            this.txtAgirlik.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kırılabilir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Yükün Derinliği:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yükün Boyu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yükün Eni:";
            // 
            // txtMesafe
            // 
            this.txtMesafe.Location = new System.Drawing.Point(94, 321);
            this.txtMesafe.Name = "txtMesafe";
            this.txtMesafe.Size = new System.Drawing.Size(122, 22);
            this.txtMesafe.TabIndex = 7;
            this.txtMesafe.TextChanged += new System.EventHandler(this.txtMesafe_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mesafe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tutar:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(51, 109);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(13, 17);
            this.lblTutar.TabIndex = 9;
            this.lblTutar.Text = "-";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(28, 363);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(81, 51);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "İsim Soyisim:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Telefon No:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(88, 74);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(13, 17);
            this.lblTelefon.TabIndex = 13;
            this.lblTelefon.Text = "-";
            // 
            // lblGonderici
            // 
            this.lblGonderici.AutoSize = true;
            this.lblGonderici.Location = new System.Drawing.Point(93, 38);
            this.lblGonderici.Name = "lblGonderici";
            this.lblGonderici.Size = new System.Drawing.Size(13, 17);
            this.lblGonderici.TabIndex = 14;
            this.lblGonderici.Text = "-";
            // 
            // Bilgiler
            // 
            this.Bilgiler.Controls.Add(this.label10);
            this.Bilgiler.Controls.Add(this.lblTelefon);
            this.Bilgiler.Controls.Add(this.lblTutar);
            this.Bilgiler.Controls.Add(this.lblGonderici);
            this.Bilgiler.Controls.Add(this.label9);
            this.Bilgiler.Controls.Add(this.label11);
            this.Bilgiler.Location = new System.Drawing.Point(12, 430);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(229, 153);
            this.Bilgiler.TabIndex = 15;
            this.Bilgiler.TabStop = false;
            this.Bilgiler.Text = "Bilgiler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 595);
            this.Controls.Add(this.Bilgiler);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtMesafe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtGonderici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Bilgiler.ResumeLayout(false);
            this.Bilgiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGonderici;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtHayir;
        private System.Windows.Forms.RadioButton rbtEvet;
        private System.Windows.Forms.TextBox txtDerinlik;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtAgirlik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMesafe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblGonderici;
        private System.Windows.Forms.GroupBox Bilgiler;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

