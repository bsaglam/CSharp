using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9.D90
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ödev 1: Kullanıcıdan do içinde kullanıcı adı ve şifre alınacak, doğru ise döngüden çıkılacak, yanlış ise sormya devam edecek.
            string username = String.Empty;
            string password = String.Empty;
            int sayac = 0;
            do
            {
                if (sayac>0)
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz hatalı");
                }
                Console.WriteLine("Kullanıcı adınızı giriniz.");
                username = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz.");
                password = Console.ReadLine();
                sayac++;
            } while (password.ToLower() != "demo" || username.ToLower() != "demo");
            Console.WriteLine("tebrikler, giriş yaptınız");
            Console.ReadLine();
            #endregion
        }
    }
}
