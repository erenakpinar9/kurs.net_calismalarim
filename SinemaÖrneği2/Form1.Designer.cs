namespace SinemaÖrneği
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.txtKoltukSayisi = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chcIndirimli = new System.Windows.Forms.CheckBox();
            this.btnBiletSat = new System.Windows.Forms.Button();
            this.btnBiletIptal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBosKoltuk = new System.Windows.Forms.Button();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(56, 314);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(46, 17);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "label3";
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(103, 30);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(100, 22);
            this.txtSalon.TabIndex = 3;
            // 
            // txtKoltukSayisi
            // 
            this.txtKoltukSayisi.Location = new System.Drawing.Point(103, 76);
            this.txtKoltukSayisi.Name = "txtKoltukSayisi";
            this.txtKoltukSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtKoltukSayisi.TabIndex = 4;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(249, 36);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(126, 57);
            this.btnOlustur.TabIndex = 5;
            this.btnOlustur.Text = "button1";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBiletIptal);
            this.groupBox1.Controls.Add(this.btnBiletSat);
            this.groupBox1.Controls.Add(this.chcIndirimli);
            this.groupBox1.Location = new System.Drawing.Point(53, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chcIndirimli
            // 
            this.chcIndirimli.AutoSize = true;
            this.chcIndirimli.Location = new System.Drawing.Point(6, 30);
            this.chcIndirimli.Name = "chcIndirimli";
            this.chcIndirimli.Size = new System.Drawing.Size(98, 21);
            this.chcIndirimli.TabIndex = 0;
            this.chcIndirimli.Text = "checkBox1";
            this.chcIndirimli.UseVisualStyleBackColor = true;
            // 
            // btnBiletSat
            // 
            this.btnBiletSat.Location = new System.Drawing.Point(24, 73);
            this.btnBiletSat.Name = "btnBiletSat";
            this.btnBiletSat.Size = new System.Drawing.Size(80, 46);
            this.btnBiletSat.TabIndex = 7;
            this.btnBiletSat.Text = "button2";
            this.btnBiletSat.UseVisualStyleBackColor = true;
            // 
            // btnBiletIptal
            // 
            this.btnBiletIptal.Location = new System.Drawing.Point(114, 73);
            this.btnBiletIptal.Name = "btnBiletIptal";
            this.btnBiletIptal.Size = new System.Drawing.Size(80, 46);
            this.btnBiletIptal.TabIndex = 8;
            this.btnBiletIptal.Text = "button3";
            this.btnBiletIptal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBosKoltuk);
            this.groupBox2.Controls.Add(this.btnBakiye);
            this.groupBox2.Location = new System.Drawing.Point(350, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 136);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnBosKoltuk
            // 
            this.btnBosKoltuk.Location = new System.Drawing.Point(114, 73);
            this.btnBosKoltuk.Name = "btnBosKoltuk";
            this.btnBosKoltuk.Size = new System.Drawing.Size(80, 46);
            this.btnBosKoltuk.TabIndex = 8;
            this.btnBosKoltuk.Text = "button4";
            this.btnBosKoltuk.UseVisualStyleBackColor = true;
            // 
            // btnBakiye
            // 
            this.btnBakiye.Location = new System.Drawing.Point(24, 73);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(80, 46);
            this.btnBakiye.TabIndex = 7;
            this.btnBakiye.Text = "button5";
            this.btnBakiye.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtKoltukSayisi);
            this.Controls.Add(this.txtSalon);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBiletIptal;
        private System.Windows.Forms.Button btnBiletSat;
        private System.Windows.Forms.CheckBox chcIndirimli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBosKoltuk;
        private System.Windows.Forms.Button btnBakiye;
    }
}

