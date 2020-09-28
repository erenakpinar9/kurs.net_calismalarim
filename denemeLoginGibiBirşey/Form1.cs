using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeLoginGibiBirşey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            if ((kullaniciAdi=="CixÇocuk28") && (sifre=="şifremçokhavalı"))
            {
                txtDurum.Text = "Giriş Başarılı!";
            }
            else
            {
                txtDurum.Text = "Giriş Yapılamadı!";
            }
        }
    }
}
