using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeSinif
{
    class Sinema
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        double bakiye;
        string salonNo;
        const double TAM = 15.0;
        const double INDIRIM = 10.0;

        public Sinema(string salonn, int koltukSayisi) 
        {
            toplamKoltukSayisi = koltukSayisi;
            salonNo = salonn;
            bosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;
        }
        public void BiletSat(bool indirim) 
        {
            bosKoltukSayisi--;
            if (indirim)
            {
                bakiye += INDIRIM;
            }
            else
            {
                bakiye += TAM;
            }
        }
        public void BiletIptal(bool indirim) 
        {
            bosKoltukSayisi++;
            if (indirim)
            {
                bakiye -= INDIRIM;
            }
            else
            {
                bakiye -= TAM;
            }
        }
        public int BosKoltukOgren() 
        {
            return bosKoltukSayisi;
        }
        public double BakiyeOgren() 
        {
            return bakiye;
        }
    }
}
