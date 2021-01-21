using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B17.Kalitim
{
     public sealed class Egitmen : Personel
    {
        public string Brans { get; set; }
        public int Seviye { get; set; }
        public Egitmen()
        {
            Console.WriteLine("eğitmen ctor");
        }
    }
}
