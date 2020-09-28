namespace deneme_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.hesapla = new System.Windows.Forms.Button();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(144, 151);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(75, 23);
            this.hesapla.TabIndex = 0;
            this.hesapla.Text = "button1";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(119, 239);
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(100, 20);
            this.txtsonuc.TabIndex = 1;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(99, 39);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(35, 20);
            this.txta.TabIndex = 2;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(214, 39);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(37, 20);
            this.txtb.TabIndex = 3;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(344, 39);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(40, 20);
            this.txtc.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 364);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.hesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
    }
}

