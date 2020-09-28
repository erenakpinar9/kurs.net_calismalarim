using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtS1.Text);
            int sayi2 = Convert.ToInt32(txtS2.Text);
            int toplam = 0;
            for (int i = sayi1+1; i < sayi2; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    toplam += i;
                    txtSonuc.Text = toplam.ToString();
                    lsbGoster.Items.Add(i);                                      
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {           
            txtS1.Text = "";
            txtS2.Text = "";            
            lsbGoster.Items.Clear();
            txtSonuc.Text = "";
        }
    }
}
