using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dersÖrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            try
            {
                int gun = Convert.ToInt32(txtRakam.Text);
                switch (gun)
                {
                    case 1:
                        txtSonuc.Text = "Pazartesi";
                        break;
                    case 2:
                        txtSonuc.Text = "Salı";
                        break;
                    case 3:
                        txtSonuc.Text = "Çarşamba";
                        break;
                    case 4:
                        txtSonuc.Text = "Perşembe";
                        break;
                    case 5:
                        txtSonuc.Text = "Cuma";
                        break;
                    case 6:
                        txtSonuc.Text = "Cumartesi";
                        break;
                    case 7:
                        txtSonuc.Text = "Pazar";
                        break;
                    default:
                        txtSonuc.Text = "Lütfen 1-7 Arası Giriş Yapınız!";
                        break;
                }
            }
            catch
            {
                txtSonuc.Text = "Lütfen Rakam Giriniz!";
            }
            
        }
    }
}
