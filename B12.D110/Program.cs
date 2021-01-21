using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12.D110
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler islem = new Islemler();
            menu:
            islem.MenuGetir();
            Console.WriteLine("yapmak istediğiniz işlemin numarasını giriniz.");
            int secim = int.Parse(Console.ReadLine());
            Console.WriteLine("1.sayiyi giriniz.");
            decimal sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayiyi giriniz.");
            decimal sayi2 = int.Parse(Console.ReadLine());

            decimal sonuc = 0;
            switch (secim)
            {
                case 1:
                    sonuc = islem.Topla(sayi1,sayi2);
                    islem.sonucYazdir(sayi1, sayi2, sonuc, "+");
                    break;
                case 2:
                    sonuc = islem.Cıkar(sayi1,sayi2);
                    islem.sonucYazdir(sayi1, sayi2, sonuc, "-");
                    break;
                case 3:
                    sonuc = islem.Carp(sayi1,sayi2);
                    islem.sonucYazdir(sayi1, sayi2, sonuc, "*");
                    break;
                case 4:
                    sonuc = islem.Bolme(sayi1,sayi2);
                    islem.sonucYazdir(sayi1, sayi2, sonuc, "/");
                    break;
                default:
                    Console.WriteLine("Menüdeki seçimlerden birini seçiniz.");
                    System.Threading.Thread.Sleep(3000);
                    goto menu;
                    
            }
            
            
            Console.WriteLine("Yeniden işlem yapmak ister misiniz?(E/H)");
            string res = Console.ReadLine();
            if (res == "E")
            {
                goto menu;
            }
        }
    }
}
