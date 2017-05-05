using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        public static void Main(string[] args)
        {

            int gun_sayi;
            int gunluk_maas;
            double vergi;
            double tamgelir;
            Console.WriteLine("Gun sayin saxil edin");
            gun_sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gunluk Maas Daxil Edin");
            gunluk_maas = Convert.ToInt32(Console.ReadLine());
            int ayliq_gelir = gun_sayi * gunluk_maas;
            if (ayliq_gelir <=1000)
            {
                vergi = ayliq_gelir * 0.04;
            }
            else
            {
                vergi = ayliq_gelir * 0.18;
            }

            tamgelir = Convert.ToInt32(ayliq_gelir) - vergi;
            Console.WriteLine(tamgelir);
         
        }
    }
}
