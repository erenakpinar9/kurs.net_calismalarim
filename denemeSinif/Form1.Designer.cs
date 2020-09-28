namespace denemeSinif
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
            this.btnBiletSat = new System.Windows.Forms.Button();
            this.btnBiletIptal = new System.Windows.Forms.Button();
            this.btnBakiyeOgren = new System.Windows.Forms.Button();
            this.btnBosKoltuk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbIndirimli = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.txtKoltukSayisi = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBiletSat
            // 
            this.btnBiletSat.Location = new System.Drawing.Point(16, 70);
            this.btnBiletSat.Name = "btnBiletSat";
            this.btnBiletSat.Size = new System.Drawing.Size(88, 51);
            this.btnBiletSat.TabIndex = 0;
            this.btnBiletSat.Text = "Bilet Sat";
            this.btnBiletSat.UseVisualStyleBackColor = true;
            this.btnBiletSat.Click += new System.EventHandler(this.btnBiletSat_Click);
            // 
            // btnBiletIptal
            // 
            this.btnBiletIptal.Location = new System.Drawing.Point(110, 70);
            this.btnBiletIptal.Name = "btnBiletIptal";
            this.btnBiletIptal.Size = new System.Drawing.Size(88, 51);
            this.btnBiletIptal.TabIndex = 1;
            this.btnBiletIptal.Text = "Bilet İptal";
            this.btnBiletIptal.UseVisualStyleBackColor = true;
            this.btnBiletIptal.Click += new System.EventHandler(this.btnBiletIptal_Click);
            // 
            // btnBakiyeOgren
            // 
            this.btnBakiyeOgren.Location = new System.Drawing.Point(18, 70);
            this.btnBakiyeOgren.Name = "btnBakiyeOgren";
            this.btnBakiyeOgren.Size = new System.Drawing.Size(88, 51);
            this.btnBakiyeOgren.TabIndex = 2;
            this.btnBakiyeOgren.Text = "Bakiye Öğren";
            this.btnBakiyeOgren.UseVisualStyleBackColor = true;
            this.btnBakiyeOgren.Click += new System.EventHandler(this.btnBakiyeOgren_Click);
            // 
            // btnBosKoltuk
            // 
            this.btnBosKoltuk.Location = new System.Drawing.Point(112, 70);
            this.btnBosKoltuk.Name = "btnBosKoltuk";
            this.btnBosKoltuk.Size = new System.Drawing.Size(88, 51);
            this.btnBosKoltuk.TabIndex = 3;
            this.btnBosKoltuk.Text = "Boş Koltuk";
            this.btnBosKoltuk.UseVisualStyleBackColor = true;
            this.btnBosKoltuk.Click += new System.EventHandler(this.btnBosKoltuk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbIndirimli);
            this.groupBox1.Controls.Add(this.btnBiletSat);
            this.groupBox1.Controls.Add(this.btnBiletIptal);
            this.groupBox1.Location = new System.Drawing.Point(42, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet İşlemleri";
            // 
            // chbIndirimli
            // 
            this.chbIndirimli.AutoSize = true;
            this.chbIndirimli.Location = new System.Drawing.Point(16, 33);
            this.chbIndirimli.Name = "chbIndirimli";
            this.chbIndirimli.Size = new System.Drawing.Size(77, 21);
            this.chbIndirimli.TabIndex = 2;
            this.chbIndirimli.Text = "İndirimli";
            this.chbIndirimli.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBakiyeOgren);
            this.groupBox2.Controls.Add(this.btnBosKoltuk);
            this.groupBox2.Location = new System.Drawing.Point(280, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 158);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor İşlemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Salon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Koltuk Sayısı:";
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(165, 45);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(100, 22);
            this.txtSalon.TabIndex = 8;
            // 
            // txtKoltukSayisi
            // 
            this.txtKoltukSayisi.Location = new System.Drawing.Point(165, 74);
            this.txtKoltukSayisi.Name = "txtKoltukSayisi";
            this.txtKoltukSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtKoltukSayisi.TabIndex = 9;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(280, 45);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(183, 51);
            this.btnOlustur.TabIndex = 10;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(255, 328);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(33, 17);
            this.lblSonuc.TabIndex = 11;
            this.lblSonuc.Text = "-----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 376);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtKoltukSayisi);
            this.Controls.Add(this.txtSalon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBiletSat;
        private System.Windows.Forms.Button btnBiletIptal;
        private System.Windows.Forms.Button btnBakiyeOgren;
        private System.Windows.Forms.Button btnBosKoltuk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.CheckBox chbIndirimli;
        private System.Windows.Forms.Label lblSonuc;
    }
}

