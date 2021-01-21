using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12.D110
{
    class Islemler
    {
        public void MenuGetir()
        {
            Console.WriteLine("***Menü***");
            Console.WriteLine("1.Toplama");
            Console.WriteLine("1.Çıkarma");
            Console.WriteLine("1.Çarpma");
            Console.WriteLine("1.Bölme");
        }

        internal decimal Topla(decimal sayi1, decimal sayi2)
        {
            return sayi1 + sayi2;
        }

        internal decimal Cıkar(decimal sayi1, decimal sayi2)
        {
            return sayi1 - sayi2;
        }

        internal decimal Carp(decimal sayi1, decimal sayi2)
        {
            return sayi1 * sayi2;

        }
        internal decimal Bolme(decimal sayi1, decimal sayi2)
        {
            return sayi1/ sayi2;
        }

        internal void sonucYazdir(decimal sayi1, decimal sayi2, decimal sonuc, string secim)
        {
            Console.WriteLine("{0} {1} {2}={3}",sayi1,secim,sayi2,sonuc);
        }
    }
}
