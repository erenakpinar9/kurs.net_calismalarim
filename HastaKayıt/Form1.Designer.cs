namespace HastaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rBtnAyakta = new System.Windows.Forms.RadioButton();
            this.rBtnYatakta = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtDogumTarihi = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rTxtAdres = new System.Windows.Forms.RichTextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtCepTelefonu = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblCepTelefonu = new System.Windows.Forms.Label();
            this.lblHastaSikayeti = new System.Windows.Forms.Label();
            this.rTxtHastaSikayeti = new System.Windows.Forms.RichTextBox();
            this.chcSigortali = new System.Windows.Forms.CheckBox();
            this.lblOdenecekUcret = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBtnAyakta
            // 
            this.rBtnAyakta.AutoSize = true;
            this.rBtnAyakta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnAyakta.Location = new System.Drawing.Point(30, 31);
            this.rBtnAyakta.Name = "rBtnAyakta";
            this.rBtnAyakta.Size = new System.Drawing.Size(116, 23);
            this.rBtnAyakta.TabIndex = 0;
            this.rBtnAyakta.TabStop = true;
            this.rBtnAyakta.Text = "Ayakta Hasta";
            this.rBtnAyakta.UseVisualStyleBackColor = true;
            // 
            // rBtnYatakta
            // 
            this.rBtnYatakta.AutoSize = true;
            this.rBtnYatakta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnYatakta.Location = new System.Drawing.Point(165, 31);
            this.rBtnYatakta.Name = "rBtnYatakta";
            this.rBtnYatakta.Size = new System.Drawing.Size(120, 23);
            this.rBtnYatakta.TabIndex = 1;
            this.rBtnYatakta.TabStop = true;
            this.rBtnYatakta.Text = "Yatakta Hasta";
            this.rBtnYatakta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDogumYeri);
            this.groupBox1.Controls.Add(this.txtDogumTarihi);
            this.groupBox1.Controls.Add(this.txtYas);
            this.groupBox1.Controls.Add(this.txtTCKimlikNo);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.lblDogumYeri);
            this.groupBox1.Controls.Add(this.lblDogumTarihi);
            this.groupBox1.Controls.Add(this.lblYas);
            this.groupBox1.Controls.Add(this.lblTCNo);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Kimlik Bilgileri";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(127, 165);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(149, 27);
            this.txtDogumYeri.TabIndex = 9;
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Location = new System.Drawing.Point(127, 133);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(149, 27);
            this.txtDogumTarihi.TabIndex = 8;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(127, 98);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(149, 27);
            this.txtYas.TabIndex = 7;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(127, 66);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(149, 27);
            this.txtTCKimlikNo.TabIndex = 6;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(127, 36);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(149, 27);
            this.txtAdSoyad.TabIndex = 5;
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Location = new System.Drawing.Point(24, 165);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(95, 19);
            this.lblDogumYeri.TabIndex = 4;
            this.lblDogumYeri.Text = "Doğum Yeri:";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(12, 133);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(107, 19);
            this.lblDogumTarihi.TabIndex = 3;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(82, 96);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(37, 19);
            this.lblYas.TabIndex = 2;
            this.lblYas.Text = "Yaş:";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(1, 64);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(118, 19);
            this.lblTCNo.TabIndex = 1;
            this.lblTCNo.Text = "T.C. Kimlik No:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(39, 38);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(80, 19);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad-Soyad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rTxtAdres);
            this.groupBox2.Controls.Add(this.txtEMail);
            this.groupBox2.Controls.Add(this.txtCepTelefonu);
            this.groupBox2.Controls.Add(this.lblAdres);
            this.groupBox2.Controls.Add(this.lblEMail);
            this.groupBox2.Controls.Add(this.lblCepTelefonu);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(356, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta İletişim Bilgileri";
            // 
            // rTxtAdres
            // 
            this.rTxtAdres.Location = new System.Drawing.Point(130, 98);
            this.rTxtAdres.Name = "rTxtAdres";
            this.rTxtAdres.Size = new System.Drawing.Size(149, 96);
            this.rTxtAdres.TabIndex = 14;
            this.rTxtAdres.Text = "";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(130, 65);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(149, 27);
            this.txtEMail.TabIndex = 13;
            // 
            // txtCepTelefonu
            // 
            this.txtCepTelefonu.Location = new System.Drawing.Point(130, 36);
            this.txtCepTelefonu.Name = "txtCepTelefonu";
            this.txtCepTelefonu.Size = new System.Drawing.Size(149, 27);
            this.txtCepTelefonu.TabIndex = 10;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(66, 96);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(54, 19);
            this.lblAdres.TabIndex = 12;
            this.lblAdres.Text = "Adres:";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(58, 65);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(62, 19);
            this.lblEMail.TabIndex = 11;
            this.lblEMail.Text = "E-Mail:";
            // 
            // lblCepTelefonu
            // 
            this.lblCepTelefonu.AutoSize = true;
            this.lblCepTelefonu.Location = new System.Drawing.Point(18, 36);
            this.lblCepTelefonu.Name = "lblCepTelefonu";
            this.lblCepTelefonu.Size = new System.Drawing.Size(105, 19);
            this.lblCepTelefonu.TabIndex = 10;
            this.lblCepTelefonu.Text = "Cep Telefonu:";
            // 
            // lblHastaSikayeti
            // 
            this.lblHastaSikayeti.AutoSize = true;
            this.lblHastaSikayeti.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaSikayeti.Location = new System.Drawing.Point(27, 326);
            this.lblHastaSikayeti.Name = "lblHastaSikayeti";
            this.lblHastaSikayeti.Size = new System.Drawing.Size(111, 19);
            this.lblHastaSikayeti.TabIndex = 10;
            this.lblHastaSikayeti.Text = "Hasta Şikayeti:";
            // 
            // rTxtHastaSikayeti
            // 
            this.rTxtHastaSikayeti.Location = new System.Drawing.Point(146, 326);
            this.rTxtHastaSikayeti.Name = "rTxtHastaSikayeti";
            this.rTxtHastaSikayeti.Size = new System.Drawing.Size(522, 96);
            this.rTxtHastaSikayeti.TabIndex = 15;
            this.rTxtHastaSikayeti.Text = "";
            // 
            // chcSigortali
            // 
            this.chcSigortali.AutoSize = true;
            this.chcSigortali.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcSigortali.Location = new System.Drawing.Point(300, 31);
            this.chcSigortali.Name = "chcSigortali";
            this.chcSigortali.Size = new System.Drawing.Size(90, 23);
            this.chcSigortali.TabIndex = 16;
            this.chcSigortali.Text = "Sigortalı";
            this.chcSigortali.UseVisualStyleBackColor = true;
            // 
            // lblOdenecekUcret
            // 
            this.lblOdenecekUcret.AutoSize = true;
            this.lblOdenecekUcret.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdenecekUcret.Location = new System.Drawing.Point(27, 459);
            this.lblOdenecekUcret.Name = "lblOdenecekUcret";
            this.lblOdenecekUcret.Size = new System.Drawing.Size(133, 19);
            this.lblOdenecekUcret.TabIndex = 10;
            this.lblOdenecekUcret.Text = "Ödenecek Ücret:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(173, 460);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(27, 19);
            this.lblSonuc.TabIndex = 17;
            this.lblSonuc.Text = "---";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.DarkGray;
            this.btnHesapla.ForeColor = System.Drawing.Color.Black;
            this.btnHesapla.Location = new System.Drawing.Point(552, 444);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(105, 46);
            this.btnHesapla.TabIndex = 18;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            this.btnHesapla.StyleChanged += new System.EventHandler(this.btnHesapla_StyleChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 510);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblOdenecekUcret);
            this.Controls.Add(this.chcSigortali);
            this.Controls.Add(this.rTxtHastaSikayeti);
            this.Controls.Add(this.lblHastaSikayeti);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rBtnYatakta);
            this.Controls.Add(this.rBtnAyakta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hasta Kayıt Programı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnAyakta;
        private System.Windows.Forms.RadioButton rBtnYatakta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtDogumTarihi;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rTxtAdres;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtCepTelefonu;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblCepTelefonu;
        private System.Windows.Forms.Label lblHastaSikayeti;
        private System.Windows.Forms.RichTextBox rTxtHastaSikayeti;
        private System.Windows.Forms.CheckBox chcSigortali;
        private System.Windows.Forms.Label lblOdenecekUcret;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnHesapla;
    }
}

