using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Donusum
{
    class Program
    {
        static void Main(string[] args)
        {
            Kesir k1 = new Kesir(5, 3);
            //k1.Yaz();

            int a = (int)k1;
            Console.WriteLine(a);

            Kesir k2 = 5;
            k2.Yaz();

            Kesir k3 = k1 + k2;
            k3.Yaz();

           Kesir k4 = 3 + k3;
            k4.Yaz();

            Kesir k5 = new Kesir(5, 1);
            Kesir k6 = new Kesir(10, 2);
            if (k5 == k6)
                Console.WriteLine("esit");
            else
                Console.WriteLine("esit degil");

        }
    }
}
