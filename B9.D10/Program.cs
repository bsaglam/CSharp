using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9.D10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            start:
            Console.WriteLine("bir değer giriniz:");
            int sayi=int.Parse(Console.ReadLine());
            double sonuc = 1;
            for (int i = sayi; i > 1; i--)
            {
                sonuc *= i;
            }
            Console.WriteLine("{0} sayısının faktöriyel değeri:{1}", sayi,sonuc);
            double carpim = 1;
            for (int i = 1; i <= sayi; i++)
            {
                carpim *= i;
            }
            Console.WriteLine("{0} sayısının faktöriyel değeri:{1}", sayi, carpim);
            goto start;
            #endregion

        }
    }
}
