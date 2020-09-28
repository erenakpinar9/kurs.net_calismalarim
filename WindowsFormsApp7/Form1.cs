using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtS1.Text);
            int sayi2 = Convert.ToInt32(txtS2.Text);
            int sonuc = sayi1 + sayi2;
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtS1.Clear();
            txtS2.Clear();
            txtSonuc.Clear();
        }
    }
}
