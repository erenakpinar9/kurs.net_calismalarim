using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int toplam = sayi1 + sayi2;
            lblSonuc.Text = toplam.ToString();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int cikar = sayi1 - sayi2;
            lblSonuc.Text = cikar.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int carp = sayi1 * sayi2;
            lblSonuc.Text = carp.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int bol = sayi1 / sayi2;
            lblSonuc.Text = bol.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSayi1.Text = "";
            txtSayi2.Clear();
            lblSonuc.Text = "";

        }
    }
}
