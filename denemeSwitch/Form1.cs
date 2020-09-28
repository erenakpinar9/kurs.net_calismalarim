using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            switch (sayi)
            {
                case 1: lblSonuc.Text = "Ocak"; break;
                case 2: lblSonuc.Text = "Şubat"; break;
                case 3: lblSonuc.Text = "Mart"; break;
                case 4: lblSonuc.Text = "Nisan"; break;
                case 5: lblSonuc.Text = "Mayıs"; break;
                case 6: lblSonuc.Text = "Haziran"; break;
                case 7: lblSonuc.Text = "Temmuz"; break;
                case 8: lblSonuc.Text = "Ağustos"; break;
                case 9: lblSonuc.Text = "Eylül"; break;
                case 10: lblSonuc.Text = "Ekim"; break;
                case 11: lblSonuc.Text = "Kasım"; break;
                case 12: lblSonuc.Text = "Aralık"; break;
                default:
                    lblSonuc.Text = "Aralıkta Değil!!!";
                    break;
            }
        }
    }
}
