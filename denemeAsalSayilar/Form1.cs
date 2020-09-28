using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeAsalSayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = Convert.ToInt32(txtS1.Text);
            s2 = Convert.ToInt32(txtS2.Text);
            int sayi = s1;
            bool durum = true;
            while (sayi < s2)
            {
                sayi++;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi%i==0)
                    {
                        durum = false;
                    }
                }
                if (durum==true && sayi!=1 && sayi < s2)
                {
                    Goster.Items.Add(sayi.ToString());
                }
                durum = true;
            }
            label3.Text = "Sayılar arasında " + Goster.Items.Count.ToString() + " tane asal sayı vardır.";
        }
    }
}
