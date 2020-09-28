using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaÖrneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sinema salon; //Başka bir sayfada açtığımı için, Form1'de Sinema classını tanımladık.
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            //Hata Ayıklama!!!
            try //Deneme
            {
                salon = new Sinema(txtSalon.Text, Convert.ToInt32(txtKoltukSayisi.Text));
                lblSonuc.Text = "Salon Oluşturuldu. Koltuk Sayısı : " + salon.BosKoltukOgren();
            }
            catch //Yakalama
            {

                lblSonuc.Text = "Salon Oluşturulamadı !!!";
            }
        }

        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            
            try
            {
                salon.BiletSat(chcIndirimli.Checked);
                lblSonuc.Text = "Bilet Satıldı. Kalan Koltuk Sayısı: " + salon.BosKoltukOgren();
            }
            catch
            {

                lblSonuc.Text = "Lütfen Boş Yerleri Doldurunuz !!!";
            }
            
        }

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            try
            {
                salon.BiletIptal(chcIndirimli.Checked);
                lblSonuc.Text = "Bilet İptal Edildi. Kalan Koltuk Sayısı: " + salon.BosKoltukOgren();
            }
            catch
            {

                lblSonuc.Text = "Lütfen Boş Yerleri Doldurunuz !!!";
            }
            
            }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            try
            {
                lblSonuc.Text = "Bakiyeniz: " + salon.BakiyeOgren();
            }
            catch
            {

                lblSonuc.Text = "Lütfen Boş Yerleri Doldurunuz!!!";
            }
        }

        private void btnBosKoltuk_Click(object sender, EventArgs e)
        {
            try
            {
                lblSonuc.Text = "Boş Koltuk Sayısı: " + salon.BosKoltukOgren();
            }
            catch
            {

                lblSonuc.Text = "Lütfen Boş Yerleri Doldurunuz !!!";
            }
        }
    }
}
