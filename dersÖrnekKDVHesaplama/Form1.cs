using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dersÖrnekKDVHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int urunFiyati = Convert.ToInt32(txtFiyat.Text);
            int urunAdedi = Convert.ToInt32(txtAdet.Text);
            if (rBtn1.Checked)
            {
                int kdvTutari = (urunFiyati * urunAdedi) * 1 / 100;
                int toplamTutar = kdvTutari + (urunFiyati * urunAdedi);
                txtKdvTutar.Text = kdvTutari.ToString();
                txtToplamTutar.Text = toplamTutar.ToString();
            }
            else if (rBtn8.Checked)
            {
                int kdvTutari = (urunFiyati * urunAdedi) * 8 / 100;
                int toplamTutar = kdvTutari + (urunFiyati * urunAdedi);
                txtKdvTutar.Text = kdvTutari.ToString();
                txtToplamTutar.Text = toplamTutar.ToString();
            }
            else
            {
                int kdvTutari = (urunFiyati * urunAdedi) * 18 / 100;
                int toplamTutar = kdvTutari + (urunFiyati * urunAdedi);
                txtKdvTutar.Text = kdvTutari.ToString();
                txtToplamTutar.Text = toplamTutar.ToString();
            }
        }
    }
}
