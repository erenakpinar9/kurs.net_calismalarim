namespace mca_deneme
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
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.txtz = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "s";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(163, 69);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(48, 22);
            this.txtx.TabIndex = 4;
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(378, 69);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(34, 22);
            this.txty.TabIndex = 5;
            // 
            // txtz
            // 
            this.txtz.Location = new System.Drawing.Point(590, 69);
            this.txtz.Name = "txtz";
            this.txtz.Size = new System.Drawing.Size(30, 22);
            this.txtz.TabIndex = 6;
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(284, 214);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(76, 22);
            this.txts.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.txtz);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "z";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.TextBox txtz;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Button button1;
    }
}

