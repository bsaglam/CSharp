using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18.SanalMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun();
            urun.EkranaYaz("urun OBJESİ");

            BaseClass bc = new BaseClass();
            bc.EkranaYaz("base OBJESİ");
            Console.ReadLine();
        }
    }
}
