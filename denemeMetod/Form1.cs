using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeMetod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnGoster_Click(object sender, EventArgs e)
        {
            int k1 = Convert.ToInt32(txtKenar1.Text);
            int k2 = Convert.ToInt32(txtKenar2.Text);
            int k3 = Convert.ToInt32(txtKenar3.Text);
            ucgenKenarlari(k1, k2, k3); //değişken, çok az bir fark var!
        }
        public void ucgenKenarlari(int k1, int k2, int k3) //argüman
        {
            if (k1==k2 && k1==k3)
            {
                txtSonuc.Text = "Eşkenar";
            }
            else if (k1!=k2 && k1!=k3)
            {
                txtSonuc.Text = "Çeşitkenar";
            }
            else
            {
                txtSonuc.Text = "İkizkenar";
            }
        }
    }
}

