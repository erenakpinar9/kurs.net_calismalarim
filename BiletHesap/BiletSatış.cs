using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletHesap
{
    public partial class BiletSatış : Form
    {
        public BiletSatış()
        {
            InitializeComponent();
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;
            string cinsiyet = txtCinsiyet.Text;
            int yas = Convert.ToInt32(txtYas.Text);
            int fiyat;
            if (cinsiyet == "Kadın")
            {
                if ((chbCam.Checked) && (yas > 30))
                {
                    fiyat = 50 + 15;
                }
                else if ((chbKoridor.Checked) && (yas > 30))
                {
                    fiyat = 40 + 15;
                }
                else if (chbCam.Checked)
                {
                    fiyat = 50;
                }
                else
                {
                    fiyat = 40;
                }
            }
            else
            {
                if ((chbCam.Checked) && (yas > 30))
                {
                    fiyat = 55 + 20;
                }
                else if ((chbKoridor.Checked) && (yas > 30))
                {
                    fiyat = 45 + 20;
                }
                else if (chbCam.Checked)
                {
                    fiyat = 55;
                }
                else
                {
                    fiyat = 45;
                }
            }
            BiletDetay.Items.Add("Bilet Bilgileri");
            BiletDetay.Items.Add(" " + " " + "------");
            BiletDetay.Items.Add("Ad-Soyad:" + " " + adSoyad);
            BiletDetay.Items.Add("Cinsiyet:" + " " + cinsiyet);
            BiletDetay.Items.Add("Yaş:" + " " + yas);
            BiletDetay.Items.Add("Fiyat:" + " " + fiyat);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtCinsiyet.Clear();
            txtYas.Clear();
            BiletDetay.Items.Clear();
        }
    }
}
