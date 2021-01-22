using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B24.D198.GirisFormu
{
   public  class SanalDatabase
    {
        public static List<Kullanici> KullaniciTablo = new List<Kullanici>();
        static SanalDatabase()
        {
            KullaniciTablo.Add(new Kullanici() { Id=1,isim="burcu",kullaniciAdi="bsaglam",sifre="1"});
            KullaniciTablo.Add(new Kullanici() { Id = 1, isim = "burcu", kullaniciAdi = "bsonmez", sifre = "12" });
        }
    }
}
