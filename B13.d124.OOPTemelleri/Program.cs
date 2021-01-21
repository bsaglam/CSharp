using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B13.d124.OOPTemelleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.isim = "burcu";
            m1.soyisim = "sağlam";
            m1.cinsiyet = 1;
            m1.TCKN = "12573456";

            Musteri m2 = m1;
            m2.isim = "selda";

            //m2 = null;
            //m1 = null;
            string isim = m2.isim;
            
        }
    }
}
