using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B17.ODEV
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Marka = "Hp";
            bilgisayar.Model = "E490";
            bilgisayar.KampanyaFiyat = 1600M;
            bilgisayar.AlisFiyat = 1500M;
            bilgisayar.SatisFiyat = 1800M;
            bilgisayar.barkod = "1234567890";
            SanalDatabase.UrunEkle(bilgisayar);


            Bilgisayar b2 = new Bilgisayar();
            b2.Marka = "Hp";
            b2.Model = "E490";
            b2.KampanyaFiyat = 1600M;
            b2.AlisFiyat = 1500M;
            b2.SatisFiyat = 1000M;
            b2.barkod = "1234567890";
             
            SanalDatabase.UrunEkle(b2);

            Console.ReadLine();
        }
    }
}
