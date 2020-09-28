using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < 100; i=i+2)
            {
                lsbGoster.Items.Add(i);
                toplam += i;
                txtGoster.Text = toplam.ToString();

            }
        }
    }
}
