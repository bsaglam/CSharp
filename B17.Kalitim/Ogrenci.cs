using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B17.Kalitim
{
    sealed class Ogrenci : TemelTip
    {
        public string bolum { get; set; }
        public int seviye { get; set; }
        public Ogrenci()
        {
            Console.WriteLine("Öğrenci ctor");
        }
    }
}
