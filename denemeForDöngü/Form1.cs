using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeForDöngü
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
            int sonuc = 0;
            if (sayi1 > sayi2)
            {
                for (int i = sayi2 + 1; i < sayi1; i++)
                {
                    sonuc = sonuc + i;
                }
                txtSonuc.Text = sonuc.ToString();
            }
            else if (sayi2 > sayi1)
            {
                for (int i = sayi1 + 1; i < sayi2; i++)
                {
                    //sonuc = sonuc + i;
                    sonuc += i;
                }
                txtSonuc.Text = sonuc.ToString();
            }
            else
            {
                txtSonuc.Text = "Sayılar Eşit!";
            }
        }
    }
}
