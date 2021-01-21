using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7.D48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İlk sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sonuç : {0}", sayi1 + sayi2);
            Console.ReadLine();
        }
    }
}
