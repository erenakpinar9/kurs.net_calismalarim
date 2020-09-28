namespace WindowsFormsApp5
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
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lsbGoster = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2:";
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(89, 86);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(122, 22);
            this.txtS2.TabIndex = 2;
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(89, 35);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(122, 22);
            this.txtS1.TabIndex = 3;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(90, 305);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(121, 22);
            this.txtSonuc.TabIndex = 4;
            // 
            // lsbGoster
            // 
            this.lsbGoster.FormattingEnabled = true;
            this.lsbGoster.ItemHeight = 16;
            this.lsbGoster.Location = new System.Drawing.Point(39, 122);
            this.lsbGoster.Name = "lsbGoster";
            this.lsbGoster.Size = new System.Drawing.Size(172, 164);
            this.lsbGoster.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sonuç:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(217, 249);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 37);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(136, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 386);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbGoster);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.txtS2);
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
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.ListBox lsbGoster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnClear;
    }
}

