using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14.D131.KapsullemeOdec
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m = new Musteri();
            m.TcKimlikNumarasi = "12961488896";
            Console.WriteLine(m.TcKimlikNumarasi);
            Console.ReadLine();
        }
    }
}
