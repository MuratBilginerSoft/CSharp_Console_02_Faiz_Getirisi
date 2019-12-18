using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAİZ_GETİRİSİ
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal a = 1000.0m, n = 0.15m, t=1 ;
            decimal f=0.0m, i, z=1.0m;

            Console.WriteLine("paranızın bankada kaç yıl kalmasını istediğinizi giirinzi=");
            i = decimal.Parse(Console.ReadLine());
            
            for (t = 1; t <= i; t++)
            {
                f = (a * n * z) / 100;

                Console.WriteLine(t + "yıl sonra faiz getirisi=" + f);

                a = a + f;
                Console.WriteLine(t + "yıl sonra anapara=" + a);

            }

            Console.ReadKey();







        }
    }
}
