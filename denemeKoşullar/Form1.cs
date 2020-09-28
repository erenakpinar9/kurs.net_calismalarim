using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeKoşullar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(txtYas.Text);
            if (yas>=20)
            {
                lblSonuc.Text = "Askere Gitmelisin!";
            }
            else
            {
                lblSonuc.Text = "Askere Gidemezsin";
            }
        }
    }
}
