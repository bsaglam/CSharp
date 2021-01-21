using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8.D71
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

            if (secim == 1) sonuc = Sayi1 + sayi2;
            else if (secim == 2) sonuc = Sayi1 - sayi2;
            else if (secim == 3) sonuc = Sayi1 * sayi2;
            else if (secim == 4) sonuc = Sayi1 / sayi2;
            else Console.WriteLine("Aralık dışında değer girdiniz.");

            Console.WriteLine("seçtiğiniz işlem: {0}", secim);
            Console.WriteLine("işleminizin sonucu:{0}",sonuc);
            Console.ReadLine();
        }
    }
}
