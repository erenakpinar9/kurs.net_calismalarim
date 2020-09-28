using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize = Convert.ToInt32(txtVize.Text);
            int final = Convert.ToInt32(txtFinal.Text);
            double ort = (vize * 0.4) + (final * 0.6);
            if ((ort >= 85) && (ort <= 100))
            {
                lblDurum.Text = "AA İle Geçti";
            }
            else if ((ort >= 65) && (ort <= 84))
            {
                lblDurum.Text = "BB İle Geçti";
            }
            else if ((ort >= 45) && (ort <= 64))
            {
                lblDurum.Text = "CC İle Geçti";
            }
            else if ((ort >= 25) && (ort <= 44))
            {
                lblDurum.Text = "DD İle Şartlı Geçti";
            }
            else if ((ort >= 0) && (ort <= 24))
            {
                lblDurum.Text = "FF ile Kaldı";
            }

            /*if (ort >= 80 && ort <= 100)
            {
            lblDurum.Text = "AA ile Geçti";
            }
            else if (ort >= 65 && ort <= 79)
            {
            lblDurum.Text = "BB ile Geçti";
            }
            else if (ort >= 40 && ort <= 64)
            {
            lblDurum.Text = "CC ile Geçti";
            }
            else if (ort >= 20 && ort <= 39)
            {
             lblDurum.Text = "DD ile Şartlı Geçti";
            }
            else if (ort >= 0 && ort <= 19)
            {
            lblDurum.Text = "FF ile Kaldı";
            }*/

        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }
    }
}
