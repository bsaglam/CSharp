using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8.D73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi1 değerini giriniz.");
            int Sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayi2 değerini giriniz.");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Yapılacak işlemi seçiniz.");
            Console.WriteLine("1.Toplama");
            Console.WriteLine("2.Çıkarma");
            Console.WriteLine("3.Çarpma");
            Console.WriteLine("4.bölme");
            int secim = int.Parse(Console.ReadLine());
            double sonuc = 0;
            switch (secim)
            {
                case 1:
                    sonuc = Sayi1 + sayi2;
                    break;
                case 2:
                    sonuc = Sayi1 - sayi2;
                    break;
                case 3:
                    sonuc = Sayi1 * sayi2;
                    break;
                case 4:
                    sonuc = Sayi1 / sayi2;
                    break;
            }
            Console.WriteLine("sonuc{0} : ", sonuc);
            Console.ReadLine();
        }
    }
}
