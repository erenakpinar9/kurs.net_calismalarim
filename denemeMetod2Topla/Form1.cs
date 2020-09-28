using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeMetod2Topla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtS1.Text);
            int s2 = Convert.ToInt32(txtS2.Text);
            topla(s1, s2);
        }
        public void topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            txtSonuc.Text = sonuc.ToString();
        }
    }
}
