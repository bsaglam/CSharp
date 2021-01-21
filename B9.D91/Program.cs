using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9.D91
{
    class Program
    {
        static void Main(string[] args)
        {
            int sistemSayi = 0;
            int tahmin = 0;
            int sayac = 0;
            Console.WriteLine("Sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Random random = new Random();
            sistemSayi = random.Next(1, sayi);
            do
            {
                Console.WriteLine("Tahmin ediniz");
                tahmin = int.Parse(Console.ReadLine());
                sayac++;
            } while (sistemSayi != tahmin);
            Console.WriteLine("{0} denemede sayıyı tahmine ttiniz.",sayac);
            Console.ReadLine();
        }
    }
}
