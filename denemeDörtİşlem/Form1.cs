using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeDörtİşlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtS1.Text);
            int sayi2 = Convert.ToInt32(txtS2.Text);
            int topla = sayi1 + sayi2;
            txtSonuc.Text = topla.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtS1.Text);
            int sayi2 = Convert.ToInt32(txtS2.Text);
            int cikar = sayi1 - sayi2;
            txtSonuc.Text = cikar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtS1.Text);
            int sayi2 = Convert.ToInt32(txtS2.Text);
            int carp = sayi1 * sayi2;
            txtSonuc.Text = carp.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtS1.Text);
            int sayi2 = Convert.ToInt32(txtS2.Text);
            int bol = sayi1 / sayi2;
            txtSonuc.Text = bol.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtS1.Clear();
            txtS2.Clear();
            txtSonuc.Clear();
        }


    }
}
