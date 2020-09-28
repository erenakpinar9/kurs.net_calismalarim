using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeString2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            if (sayi>0)
            {
                txtSonuc.Text = "Sayı Pozitif";
            }
            else if (sayi<0)
            {
                txtSonuc.Text = "Sayı Negatif";
            }
            else
            {
                txtSonuc.Text = "Sayi Sıfır" ;
            }
        }
    }
}
