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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            if ((kullanici == "admin") && (sifre == "1234"))
            {
                BiletSatış frm = new BiletSatış();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!!!");
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
        }
    }
}
