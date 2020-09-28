using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi_Çakma_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sonuc;
        int toplam;
        int cikarma;
        int carpma;
        int bolme;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtS1.Text);
            int sayi2 = Convert.ToInt32(txtS2.Text);
            if (chbTopla.Checked)
            {
                toplam = sayi1 + sayi2;
            }
            if (chbCikar.Checked)
            {
                cikarma = sayi1 - sayi2;
            }
            if (chbCarp.Checked)
            {
                carpma = sayi1 * sayi2;
            }
            if (chbBol.Checked)
            {
                bolme = sayi1 / sayi2;
            }
            Sonuc.Items.Add("Toplam:" + " " + toplam);
            Sonuc.Items.Add("Çıkarma:" + " " + cikarma);
            Sonuc.Items.Add("Çarpma:" + " " + carpma);
            Sonuc.Items.Add("Bölme:" + " " + bolme);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtS1.Clear();
            txtS2.Clear();
            Sonuc.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
