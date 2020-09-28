using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // sql veritabanı kullanacaksak eklemek zorunlu!!!

namespace sehirlerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = sehirDB; Integrated Security = True"); // bağlantıyı kurduk
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open(); // bağlantıyı açtık
            SqlCommand komut = new SqlCommand("select sehirAd from tbl_Sehirler", baglanti);
            SqlDataReader sdr = komut.ExecuteReader(); // değer okuturken kullanıyoruz. delete, select gibileri kullanırken ExecuteNonQuey kullanacağız.
            while (sdr.Read()) // sdr'nin içini okuyabiliğim sürece
            {
                comboBox1.Items.Add(sdr[0]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            baglanti.Open();
            SqlCommand komutIlce = new SqlCommand("select ilceAD from tbl_Ilceler where sehirID=@p1", baglanti);
            komutIlce.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex + 1); // sql index'i 1'den başladığı için bunu yapmamız lazım!
            SqlDataReader caferReader = komutIlce.ExecuteReader();
            while (caferReader.Read())
            {
                comboBox2.Items.Add(caferReader[0]);
            }
            baglanti.Close(); // bağlantıyı kapattık.
        }
    }
}
