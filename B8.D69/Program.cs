using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8.D69
{
    class Program
    {
        static void Main(string[] args)
        {
            string birinci = String.Empty;
            string ikinci = String.Empty;
            string ucuncu = String.Empty;
            double ortalama = 0;
            Console.WriteLine("1.notunuzu giriniz.");
            birinci = Console.ReadLine();
            Console.WriteLine("1.notunuzu giriniz.");
            ikinci = Console.ReadLine();
            Console.WriteLine("1.notunuzu giriniz.");
            ucuncu = Console.ReadLine();
            ortalama = (int.Parse(birinci) + int.Parse(ikinci) + int(ucuncu))/3;
            if (ortalama < 50) Console.WriteLine("FF");
            else if (ortalama >= 50 && ortalama < 60) Console.WriteLine("CB");
            else if (ortalama >= 60 && ortalama < 70) Console.WriteLine("BB");
            else if (ortalama >= 70 && ortalama < 80) Console.WriteLine("BA");
            else if (ortalama >= 81 && ortalama < 100) Console.WriteLine("AA");
            

        }
    }
}
