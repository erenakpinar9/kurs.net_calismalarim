using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaÖrneği
{
    class Sinema
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        double bakiye;
        string salonNo;


        const double TAM = 15.0;
        const double INDIRIMLI = 10.0;

        //constructor - yapıcı methodumuz.
        public Sinema(string salonn, int koltuksayi)
        {
            toplamKoltukSayisi = koltuksayi;
            salonNo = salonn;
            bosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;
        }
        public void BiletSat(bool indirimli)
        {
            bosKoltukSayisi--;
            if (indirimli)
            {
                bakiye += INDIRIMLI;
            }
            else
            {
                bakiye += TAM;
            }
        }
        public void BiletIptal(bool indirimli)
        {
            if (bosKoltukSayisi < toplamKoltukSayisi)
            {
                bosKoltukSayisi++;
                if (indirimli)
                {
                    bakiye -= INDIRIMLI;
                }
                else
                {
                    bakiye -= TAM;
                }
            }
            else
            {

            }
            //bosKoltukSayisi++;
            //if (indirimli)
            //{
            //    bakiye -= INDIRIMLI;
            //}
            //else
            //{
            //    bakiye -= TAM;
            //}
        }
        public int BosKoltukOgren()
        {
            return bosKoltukSayisi;
        }
        public double BakiyeOgren()
        {
            return bakiye; //return -> Methodun dışına çıkarma, başka işlemlerde kullanılabilmesini sağlama.
        }
    }
}
