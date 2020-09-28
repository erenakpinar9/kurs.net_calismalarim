using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullanici.Text;
            string sifre = txtSifre.Text;
            if ((kullanici == "admin") && (sifre == "123"))
            {
                MessageBox.Show("Başarılı Giriş!!!");
            }
            else
            {
                txtKullanici.Clear();
                txtSifre.Clear();
                MessageBox.Show("Hatalı Giriş!!!");
            }
        }
    }
}
