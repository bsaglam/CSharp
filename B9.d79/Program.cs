using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9.d79
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 ile 10 arasındaki sayıyı yazdır
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region 1 ile 100 arasındaki çift sayıları yazdır
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region 1 den 100 e kadar olan çift sayıların toplamını yazdır.
            int sonuc = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    sonuc += i;
                }
            }
            Console.WriteLine(sonuc);
            #endregion
            Console.ReadLine();
        }
    }
}
