using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziÖrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //Random sınıfına rnd ile ulaşıyoruz.
            int[] sayilar = new int[30];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 100);
            }
            Array.Sort(sayilar);

            foreach (int each in sayilar)
            {
                listBox1.Items.Add(each);
            }
        }
    }
}
