namespace soruHoca1
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
            this.label10 = new System.Windows.Forms.Label();
            this.txt1Renk = new System.Windows.Forms.TextBox();
            this.txt2Renk = new System.Windows.Forms.TextBox();
            this.lstSol = new System.Windows.Forms.ListBox();
            this.lstSag = new System.Windows.Forms.ListBox();
            this.btnSagTasi = new System.Windows.Forms.Button();
            this.btnSolTasi = new System.Windows.Forms.Button();
            this.btn1Ekle = new System.Windows.Forms.Button();
            this.btn2Ekle = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renk:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Renk:";
            // 
            // txt1Renk
            // 
            this.txt1Renk.Location = new System.Drawing.Point(98, 27);
            this.txt1Renk.Name = "txt1Renk";
            this.txt1Renk.Size = new System.Drawing.Size(100, 22);
            this.txt1Renk.TabIndex = 10;
            // 
            // txt2Renk
            // 
            this.txt2Renk.Location = new System.Drawing.Point(340, 27);
            this.txt2Renk.Name = "txt2Renk";
            this.txt2Renk.Size = new System.Drawing.Size(100, 22);
            this.txt2Renk.TabIndex = 15;
            // 
            // lstSol
            // 
            this.lstSol.FormattingEnabled = true;
            this.lstSol.ItemHeight = 16;
            this.lstSol.Location = new System.Drawing.Point(34, 135);
            this.lstSol.Name = "lstSol";
            this.lstSol.Size = new System.Drawing.Size(164, 228);
            this.lstSol.TabIndex = 22;
            // 
            // lstSag
            // 
            this.lstSag.FormattingEnabled = true;
            this.lstSag.ItemHeight = 16;
            this.lstSag.Location = new System.Drawing.Point(278, 135);
            this.lstSag.Name = "lstSag";
            this.lstSag.Size = new System.Drawing.Size(164, 228);
            this.lstSag.TabIndex = 23;
            // 
            // btnSagTasi
            // 
            this.btnSagTasi.Location = new System.Drawing.Point(215, 200);
            this.btnSagTasi.Name = "btnSagTasi";
            this.btnSagTasi.Size = new System.Drawing.Size(48, 37);
            this.btnSagTasi.TabIndex = 24;
            this.btnSagTasi.Text = ">>";
            this.btnSagTasi.UseVisualStyleBackColor = true;
            this.btnSagTasi.Click += new System.EventHandler(this.btnSagTasi_Click);
            // 
            // btnSolTasi
            // 
            this.btnSolTasi.Location = new System.Drawing.Point(215, 257);
            this.btnSolTasi.Name = "btnSolTasi";
            this.btnSolTasi.Size = new System.Drawing.Size(48, 38);
            this.btnSolTasi.TabIndex = 25;
            this.btnSolTasi.Text = "<<";
            this.btnSolTasi.UseVisualStyleBackColor = true;
            this.btnSolTasi.Click += new System.EventHandler(this.btnSolTasi_Click);
            // 
            // btn1Ekle
            // 
            this.btn1Ekle.Location = new System.Drawing.Point(97, 66);
            this.btn1Ekle.Name = "btn1Ekle";
            this.btn1Ekle.Size = new System.Drawing.Size(101, 45);
            this.btn1Ekle.TabIndex = 26;
            this.btn1Ekle.Text = "Ekle";
            this.btn1Ekle.UseVisualStyleBackColor = true;
            this.btn1Ekle.Click += new System.EventHandler(this.btn1Ekle_Click);
            // 
            // btn2Ekle
            // 
            this.btn2Ekle.Location = new System.Drawing.Point(340, 66);
            this.btn2Ekle.Name = "btn2Ekle";
            this.btn2Ekle.Size = new System.Drawing.Size(100, 45);
            this.btn2Ekle.TabIndex = 27;
            this.btn2Ekle.Text = "Ekle";
            this.btn2Ekle.UseVisualStyleBackColor = true;
            this.btn2Ekle.Click += new System.EventHandler(this.btn2Ekle_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(160, 397);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(23, 17);
            this.lblSonuc.TabIndex = 28;
            this.lblSonuc.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 444);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btn2Ekle);
            this.Controls.Add(this.btn1Ekle);
            this.Controls.Add(this.btnSolTasi);
            this.Controls.Add(this.btnSagTasi);
            this.Controls.Add(this.lstSag);
            this.Controls.Add(this.lstSol);
            this.Controls.Add(this.txt2Renk);
            this.Controls.Add(this.txt1Renk);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "q";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt1Renk;
        private System.Windows.Forms.TextBox txt2Renk;
        private System.Windows.Forms.ListBox lstSol;
        private System.Windows.Forms.ListBox lstSag;
        private System.Windows.Forms.Button btnSagTasi;
        private System.Windows.Forms.Button btnSolTasi;
        private System.Windows.Forms.Button btn1Ekle;
        private System.Windows.Forms.Button btn2Ekle;
        private System.Windows.Forms.Label lblSonuc;
    }
}

