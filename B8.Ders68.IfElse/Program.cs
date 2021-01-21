using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8.Ders68.IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adınızı giriniz:");
            string kadi=Console.ReadLine();
            Console.Write("Şifrenizi giriniz:");
            string sifre = Console.ReadLine();
            if (kadi == "bsaglam" && sifre == "123456") Console.WriteLine("başarılı giriş"); else Console.WriteLine("Hatalı giriş");
            Console.ReadLine();
        }
    }
}
