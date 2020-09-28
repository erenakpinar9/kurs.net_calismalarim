namespace WindowsFormsApp4
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lsbGoster = new System.Windows.Forms.ListBox();
            this.txtGoster = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(90, 31);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(158, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Göster ve Hesapla";
            this.btnHesapla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lsbGoster
            // 
            this.lsbGoster.FormattingEnabled = true;
            this.lsbGoster.ItemHeight = 16;
            this.lsbGoster.Location = new System.Drawing.Point(56, 60);
            this.lsbGoster.Name = "lsbGoster";
            this.lsbGoster.Size = new System.Drawing.Size(224, 244);
            this.lsbGoster.TabIndex = 1;
            // 
            // txtGoster
            // 
            this.txtGoster.Location = new System.Drawing.Point(90, 310);
            this.txtGoster.Name = "txtGoster";
            this.txtGoster.Size = new System.Drawing.Size(158, 22);
            this.txtGoster.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 414);
            this.Controls.Add(this.txtGoster);
            this.Controls.Add(this.lsbGoster);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox lsbGoster;
        private System.Windows.Forms.TextBox txtGoster;
    }
}

