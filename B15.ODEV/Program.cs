using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B15.ODEV
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri()
            {
                Id = 1,
                isim = "burcu",
                soyisim = "sağlam",
                KullaniciAdi = "bsaglam",
                mailAdresi = "bsaglam@hotmail.com",
                password = "bsaglam89"
            };

            Musteri.MusteriEkle(musteri);

        }
    }
}
