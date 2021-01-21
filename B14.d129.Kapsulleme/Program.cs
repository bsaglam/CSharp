using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14.d129.Kapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {

            //Programcı get işlemini yapabilsin ama yeni bir değer set edemesin istiyorsak
            Musteri m = new Musteri();
            Console.WriteLine(m.Email);
            Console.ReadLine();
        }
    }
}
