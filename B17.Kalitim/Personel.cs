using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B17.Kalitim
{
    public class Personel
    {
        public DateTime IsBaslangicTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int IzınGunSayisi { get; set; }
        public Personel()
        {
            Console.WriteLine("Personel ctor");
        }
    }
}
