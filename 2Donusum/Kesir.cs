using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Donusum
{
    class Kesir
    {
        public int Pay;
        public int Payda;

        public Kesir(int p,int pd)
        {
            Pay = p;
            Payda = pd;
        }

        public void Yaz()
        {
            Console.WriteLine("{0}/{1}", Pay, Payda);
        }

        public static explicit operator int(Kesir k)
        {
            //donusumun nasil yapilacagi tarif edilir
            int sonuc = k.Pay / k.Payda;
            return sonuc;

        }

        public static implicit operator Kesir(int sayi)
        {
            Kesir k = new Kesir(sayi, 1);
            return k;
        }

        public static Kesir operator +(Kesir k1, Kesir k2)
        {
            int yp = k1.Pay * k2.Payda + k2.Pay * k1.Payda;
            int ypd = k1.Payda * k2.Payda;
            Kesir k = new Kesir(yp, ypd);
            return k;
        }

        public static bool operator ==(Kesir k1, Kesir k2)
        {
            double sonuc1 = k1.Pay / k1.Payda;
            double sonuc2 = k2.Pay / k2.Payda;
            return sonuc1 == sonuc2;

        }

        public static bool operator !=(Kesir k1, Kesir k2)
        {
            return !(k1 == k2);
        }



    }
}
