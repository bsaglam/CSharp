using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9.D87
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sistemin çalışma zamanında ürettiği 1-10 arasındaki sayıyı kullanıcının tahmin etmesini istiyoruz
            Random random = new Random();
            int sayi = random.Next(1,10);
            int sayac = 0;
            while (true)
            {
                Console.WriteLine("Tahmin ettiğiniz rakamı giriniz.");
                int tahmin=int.Parse(Console.ReadLine());
                sayac++;
                if (tahmin ==  sayi)
                {
                    Console.WriteLine("Tebrikler {0}. tahminde doğru sayıyı buldunuz.",sayac);
                    break;
                }
            }
            Console.ReadLine();
            #endregion
        }
    }
}
