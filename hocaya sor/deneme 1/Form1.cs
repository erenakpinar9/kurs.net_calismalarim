using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txta.Text);
            int b = Convert.ToInt32(txtb.Text);
            int c = Convert.ToInt32(txtb.Text);
            double sonuc;
            int x, y, z;

            if (a > 0 && b > 0 && c==0)
            {
                x = (a * a) + (b * b);
                sonuc = Math.Sqrt(x);
                txtsonuc.Text = sonuc.ToString();

            }
            else if (a==0 && b > 0 && c > 0)
            {
                y = (c * c) - (b * b);
                sonuc = Math.Sqrt(y);
                txtsonuc.Text = sonuc.ToString();

            }
            else if (a > 0 && b==0 && c > 0)
            {
                z = (c * c) - (a * a);
                sonuc = Math.Sqrt(z);
                txtsonuc.Text = sonuc.ToString();

            }
            else
            {
                txtsonuc.Text = "sayıları doğru giriniz";
            }







        }
    }
}
