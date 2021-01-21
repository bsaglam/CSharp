using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12.D111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsim giriniz");
            string name = Console.ReadLine();

            Console.WriteLine("1.notu giriniz.");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.notu giriniz.");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("3.notu giriniz.");
            int sayi3 = int.Parse(Console.ReadLine());

            Islemler islemler = new Islemler();
            islemler.Hesapla(name,sayi1,sayi2,sayi3);
            System.Threading.Thread.Sleep(3000);
        }
    }
}
