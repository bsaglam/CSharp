
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12.D111
{
    class Islemler
    {
        public void Hesapla(string name, int sayi1,int sayi2,int sayi3)
        {
            decimal sonuc = ortalamaHesapla(sayi1,sayi2,sayi3);

            if (sonuc>0 && sonuc<50)
            {
                Console.WriteLine("FF");
            }
            else if (sonuc>50 && sonuc<60)
            {
                Console.WriteLine("CC");
            }
            else if (sonuc>60 && sonuc<70)
            {
                Console.WriteLine("CB");
            }
            else if(sonuc>70 && sonuc<80)
            {
                Console.WriteLine("BB");
            }
            else if(sonuc>80 && sonuc<100)
            {
                Console.WriteLine("AA");
            }
        }

        private decimal ortalamaHesapla(int sayi1, int sayi2, int sayi3)
        {
            return (sayi1 + sayi2 + sayi3) / 3;
        }
    }
}
