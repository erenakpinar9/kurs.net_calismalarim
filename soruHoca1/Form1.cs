using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soruHoca1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstSag.SelectionMode = SelectionMode.MultiSimple;
            lstSol.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btn1Ekle_Click(object sender, EventArgs e)
        {
            string renk1 = txt1Renk.Text;
            lstSol.Items.Add(renk1);
        }

        private void btn2Ekle_Click(object sender, EventArgs e)
        {
            string renk2 = txt2Renk.Text;
            lstSag.Items.Add(renk2);
        }

        private void btnSagTasi_Click(object sender, EventArgs e)
        {
            int i;
            for (i = lstSol.SelectedIndices.Count - 1; i >= 0; i--) //-1 i sor - Count'u sor
            {
                lstSag.Items.Add(lstSol.SelectedItems[i]);
                lstSol.Items.RemoveAt(lstSol.SelectedIndices[i]);
            }
        }
        private void btnSolTasi_Click(object sender, EventArgs e)
        {
            int i;
            i = lstSag.SelectedIndices.Count - 1;
            lstSol.Items.Add(lstSag.SelectedItems[i]);
            lstSag.Items.RemoveAt(lstSag.SelectedIndices[i]);

            //for (i = lstSag.SelectedIndices.Count - 1; i >= 0; i--)
            //{
            //    lstSol.Items.Add(lstSag.SelectedItems[i]);
            //    lstSag.Items.RemoveAt(lstSag.SelectedIndices[i]);
            //}
            //try
            //{
            //    i = lstSag.SelectedIndices.Count - 1;
            //    lstSol.Items.Add(lstSag.SelectedItems[i]);
            //    lstSag.Items.RemoveAt(lstSag.SelectedIndices[i]);
            //}
            //catch
            //{
            //    lblSonuc.Text = "Listede herhangi bir bilgi yoktur!";
            //}
        }
    }
}
