using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtEvet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMesafe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //kilo en boy derinlik, min. 5tl, min ağırlık 1, her kilo 10tl
            //en*boy*derinlik>5 5tl, kırılabilir 10tl, her 100km 10tl eklesin.
            double tutar;
            int agirlik = Convert.ToInt32(txtAgirlik.Text);
            int boy = Convert.ToInt32(txtBoy.Text);
            int en = Convert.ToInt32(txtEn.Text);
            int derinlik = Convert.ToInt32(txtDerinlik.Text);
            int mesafe = Convert.ToInt32(txtMesafe.Text);
            string gonderici = txtGonderici.Text.ToString();
            string telefon = txtTelefon.Text.ToString();
            if (rbtEvet.Checked == true)
            {

                if (agirlik >= 10)
                {
                    tutar = (boy * en * derinlik * mesafe * agirlik * agirlik) + 10;
                    lblTutar.Text = tutar.ToString();
                }
                else
                {
                    tutar = (boy * en * derinlik * mesafe * agirlik) + 10;
                    lblTutar.Text = tutar.ToString();
                }
            }
            else
            {
                if (agirlik >= 10)
                {
                    tutar = boy * en * derinlik * mesafe * agirlik * agirlik;
                    lblTutar.Text = tutar.ToString();
                }
                else
                {
                    tutar = boy * en * derinlik * mesafe * agirlik;
                    lblTutar.Text = tutar.ToString();
                }
            }
            lblGonderici.Text = gonderici.ToString();
            lblTelefon.Text = telefon.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
