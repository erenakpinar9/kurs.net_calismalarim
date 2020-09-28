using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAyir_Click(object sender, EventArgs e)
        {
            string cumle;
            string[] kelimeler;
            List<string> tekil = new List<string>();
            cumle = txtCumle.Text;
            cumle = cumle.ToLower();
            cumle = cumle.Replace(",", "").Replace(":", "").Replace(".", "").Replace(";", "");
            kelimeler = cumle.Split(' ');
            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (tekil.Contains(kelimeler[i]))
                {
                    tekil.Add(kelimeler[i]);
                }
            }
            foreach (string k in tekil)
            {
                int sayac = 0;
                for (int i = 0; i < kelimeler.Length; i++)
                {
                    if (kelimeler[i]==k)
                    {
                        sayac++;
                    }
                }
                listBox1.Items.Add(k + " --->" + sayac + "  adet");
            }
        }
    }
}
