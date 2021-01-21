using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20.Partialclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            o.isim = "burcu";
            o.Soyisim = "sonmez";
            o.Id = 1;

           int result = o.Ekle(o);

        }
    }
}
