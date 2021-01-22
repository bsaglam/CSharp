using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayitEklemeVeListeleme_Notify
{
    public class Musteri
    {
        public Guid Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }

        public override string ToString()
        {
            return Isim + " " + Soyisim;
        }
    }
}
