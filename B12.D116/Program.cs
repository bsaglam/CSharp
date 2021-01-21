using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12.D116
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Ref anahtar kelimesi kullanımı
        //    int sayi = 0;
        //    degerAta(ref sayi);

        //}

        //static void degerAta(ref int gelenDeger)
        //{
        //    gelenDeger = 10;
        //}

        //out parametresi ile deneyelim
        static void Main(string[] args)
        {
            //Ref anahtar kelimesi kullanımı
            int sayi = 0;
            degerAta(out sayi);

        }

        static void degerAta(out int gelenDeger)
        {
            gelenDeger = 10;
        }
    }
}
