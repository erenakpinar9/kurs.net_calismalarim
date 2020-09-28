using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace denemeVeritabanıbağlantı
{
    public partial class Login : System.Web.UI.Page
    {
        sql baglan = new sql();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komutGiris = new SqlCommand("select * from tblLogin where kullaniciAdi=@kul and sifre=@sf", baglan.sqlbaglanti()); //güvenlik için parametre kullandık!
            komutGiris.Parameters.AddWithValue("kul", txtKullanici.Text);
            komutGiris.Parameters.AddWithValue("sf", txtSifre.Text);
            SqlDataReader sqlDR = komutGiris.ExecuteReader();
            if (sqlDR.Read()) //Girilen değerler DB'de eşleşiyorsa
            {
                lblGirisUyari.Text = "Giriş Başarılı!";
                Response.Redirect("Admin.aspx");
                //lblGirisUyari.Visible = false;
            }
            else
            {
                lblGirisUyari.Visible = true;
                lblGirisUyari.Text = "Hatalı Giriş!";
                txtKullanici.Text = "";
                txtSifre.Text = "";
            }
        }
    }
}