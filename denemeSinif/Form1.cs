using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeSinif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sinema salon;
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Sinema(txtSalon.Text, Convert.ToInt32(txtKoltukSayisi.Text));
                lblSonuc.Text = "Salon Oluşturuldu.";
            }
            catch
            {
                lblSonuc.Text = "Salon Oluşturulamadı!";
            }
        }

        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            try
            {
                salon.BiletSat(chbIndirimli.Checked);
                lblSonuc.Text = "Bilet Satılmıştır. Kalan Koltuk Sayısı: " + salon.BosKoltukOgren();
            }
            catch
            {
                lblSonuc.Text = "Önce Salon Oluşturunuz!";
            }

        }

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            try
            {
                salon.BiletIptal(chbIndirimli.Checked);
                lblSonuc.Text = "Bilet İptal Edilmiştir. Kalan Koltuk Sayısı: " + salon.BosKoltukOgren();
            }
            catch
            {
                lblSonuc.Text = "Önce Bilet Satmalısınız!";
            }

        }

        private void btnBakiyeOgren_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "Bakiyeniz: " + salon.BakiyeOgren() + " TL";
        }

        private void btnBosKoltuk_Click(object sender, EventArgs e)
        {
            try
            {
                lblSonuc.Text = "Boş Koltuk Sayısı: " + salon.BosKoltukOgren();
            }
            catch
            {
                lblSonuc.Text = "Önce Salon Oluşturmalısınız!";
            }

        }
    }
}
