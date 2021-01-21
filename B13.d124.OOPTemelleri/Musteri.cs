using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B13.d124.OOPTemelleri
{
    class Musteri
    {
        public string TCKN { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }

        internal void MusterGoster()
        {
            Console.WriteLine("deneme");
        }
    }
}
