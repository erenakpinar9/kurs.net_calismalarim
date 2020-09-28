using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; //kesin yazmalıyız!!
using System.Data.SqlClient;

namespace HastaKayıt
{
    public class sql
    {
        public SqlConnection sqlbaglanti()
        {
            SqlConnection baglantiNesnesi = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = HastaKayitDB; Integrated Security = True");
            baglantiNesnesi.Open();
            SqlConnection.ClearPool(baglantiNesnesi);
            SqlConnection.ClearAllPools();

            return baglantiNesnesi;
        }
    }
}