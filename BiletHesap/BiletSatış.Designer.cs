namespace BiletHesap
{
    partial class BiletSatış
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.chbKoridor = new System.Windows.Forms.CheckBox();
            this.chbCam = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.BiletDetay = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yaş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(93, 20);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(120, 22);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Location = new System.Drawing.Point(93, 58);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(120, 22);
            this.txtCinsiyet.TabIndex = 4;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(93, 97);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(120, 22);
            this.txtYas.TabIndex = 5;
            // 
            // chbKoridor
            // 
            this.chbKoridor.AutoSize = true;
            this.chbKoridor.Location = new System.Drawing.Point(263, 69);
            this.chbKoridor.Name = "chbKoridor";
            this.chbKoridor.Size = new System.Drawing.Size(18, 17);
            this.chbKoridor.TabIndex = 6;
            this.chbKoridor.UseVisualStyleBackColor = true;
            // 
            // chbCam
            // 
            this.chbCam.AutoSize = true;
            this.chbCam.Location = new System.Drawing.Point(263, 103);
            this.chbCam.Name = "chbCam";
            this.chbCam.Size = new System.Drawing.Size(18, 17);
            this.chbCam.TabIndex = 7;
            this.chbCam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Koridor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Koltuk Seçimi";
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Location = new System.Drawing.Point(130, 140);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(83, 49);
            this.btnBiletAl.TabIndex = 11;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // BiletDetay
            // 
            this.BiletDetay.FormattingEnabled = true;
            this.BiletDetay.ItemHeight = 16;
            this.BiletDetay.Location = new System.Drawing.Point(29, 205);
            this.BiletDetay.Name = "BiletDetay";
            this.BiletDetay.Size = new System.Drawing.Size(315, 116);
            this.BiletDetay.TabIndex = 12;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(130, 342);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(95, 25);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // BiletSatış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 379);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.BiletDetay);
            this.Controls.Add(this.btnBiletAl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbCam);
            this.Controls.Add(this.chbKoridor);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BiletSatış";
            this.Text = "BiletSatış";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.CheckBox chbKoridor;
        private System.Windows.Forms.CheckBox chbCam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBiletAl;
        private System.Windows.Forms.ListBox BiletDetay;
        private System.Windows.Forms.Button btnTemizle;
    }
}