using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12.D117.Params
{
    class Program
    {
        static void Main(string[] args)
        {
            topla(1, 2, 4, 5, 6, 7, 9);
        }

        // params herzaman son parametre olarak yer almalıdır.
        private static void topla(int sayi1,params int[] sayi)
        {
            int toplam = 0;
            foreach (var item in sayi)
	        {
                toplam+=item;
	        }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
