using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9.D86
{
    class Program
    {
        static void Main(string[] args)
        {
            //start:
            //Console.WriteLine("Sayısal bir değer giriniz.");
            //int sayi=int.Parse(Console.ReadLine());
            //while (sayi>0)
            //{
            //    Console.WriteLine(sayi);
            //    sayi--;
            //}
            //goto start;

            #region - Kullanıcıdan gelen değerleri 0 dan küçük değer gelene kadar toplar.
            Console.WriteLine("Toplanacak olan sayıları giriniz:");
            int sayi =0;
            int toplam = 0;
            while (true)
            {
                sayi = int.Parse(Console.ReadLine());
                if (sayi >0 )
                {
                    toplam += sayi;
                }
                else break;
            }

            Console.WriteLine(toplam);
            Console.ReadLine();
            #endregion

        }
    }
}
