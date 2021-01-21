using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12.B120.LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalFuncKullanimi(12,12);
        }

        static void LocalFuncKullanimi(int sayi1, int sayi2)
        {
            int topla(int gelenSayi1,int gelenSayi2)
            {
                return gelenSayi1 + gelenSayi2;
            }
            int toplam = topla(3,4);
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
