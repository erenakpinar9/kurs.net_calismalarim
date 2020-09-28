using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mca_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt32(txtx.Text);
            //float y = Convert.ToInt32(txty.Text);
            //float z = Convert.ToInt32(txtz.Text);

            //float a = (x * y) / (z) + (x * z);
            double sonuc = Math.Sqrt(x);
            txts.Text = sonuc.ToString();
        
        
        
        }

    }
}
