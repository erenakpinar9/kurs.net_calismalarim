using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeIF_ELSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int v = Convert.ToInt32(txtVize.Text);
            int f = Convert.ToInt32(txtFinal.Text);
            double ort;
            ort = ((v * 40 / 100) + (f * 60 / 100));
            if ((ort > 82) && (ort <= 100))
            {
                txtSonuc.Text = "Geçti" + " " + ort.ToString();
            }
            else if ((ort > 60) && (ort <= 82))
            {
                txtSonuc.Text = "Geçti" + " " + ort.ToString();
            }
            else if ((ort > 39) && (ort <= 59))
            {
                txtSonuc.Text = "Geçti" + " " + ort.ToString();
            }
            else
            {
                txtSonuc.Text = "Kaldı" + " " + ort.ToString();
            }
        }
    }
}
