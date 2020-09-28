namespace WindowsFormsApp8
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
            this.txtCumle = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAyir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cümle:";
            // 
            // txtCumle
            // 
            this.txtCumle.Location = new System.Drawing.Point(64, 24);
            this.txtCumle.Name = "txtCumle";
            this.txtCumle.Size = new System.Drawing.Size(225, 22);
            this.txtCumle.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(316, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 196);
            this.listBox1.TabIndex = 2;
            // 
            // btnAyir
            // 
            this.btnAyir.Location = new System.Drawing.Point(202, 52);
            this.btnAyir.Name = "btnAyir";
            this.btnAyir.Size = new System.Drawing.Size(87, 43);
            this.btnAyir.TabIndex = 3;
            this.btnAyir.Text = "Ayır";
            this.btnAyir.UseVisualStyleBackColor = true;
            this.btnAyir.Click += new System.EventHandler(this.btnAyir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 243);
            this.Controls.Add(this.btnAyir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtCumle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCumle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAyir;
    }
}

