using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeIFELSEIF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;
            int yas = Convert.ToInt32(txtYas.Text);

            if (rBtnErkek.Checked)
            {
                if (yas>20)
                {
                    lblGoster.Text = "Askere Gidebilir.";
                }
                else
                {
                    lblGoster.Text = "Askere Gidemez!";
                }
            }
            else if (rBtnKadın.Checked)
            {
                lblGoster.Text = "Askere Gidemez!";
            }
            else
            {
                lblGoster.Text = "Cinsiyet Belirtmelisiniz!";
            }
            try
            {
                if (adSoyad == txtAdSoyad.Text)
                {
                    lblAdSoyad2.Text = " " + adSoyad;
                }
            }
            catch
            {
                lblAskerlikDurumu.Text = "Lütfen Ad Soyad Giriniz!";
            }

        }
    }
}
