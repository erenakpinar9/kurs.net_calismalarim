using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayi1 = Convert.ToInt32(txtS1.Text);
            int sayi2 = Convert.ToInt32(txtS2.Text);
            if (sayi2>sayi1)
            {
                for (int i = sayi1+1; i < sayi2; i++)
                {
                    toplam += i;
                    //toplam = toplam + i; - Yukarıdaki ile aynı.
                    txtSonuc.Text = toplam.ToString();
                }
            }
            else if (sayi1>sayi2)
            {
                for (int i = sayi2+1; i < sayi1; i++)
                {
                    toplam += i;
                    txtSonuc.Text = toplam.ToString();
                }
            }
            else
            {
                txtSonuc.Text = 0.ToString();
            }
       
            //int toplam = 0;
            //for (int i = sayi1+1; i < sayi2; i++)
            //{
            //    toplam = toplam + i;
            //    txtSonuc.Text = toplam.ToString();
            //}
        }
    }
}
