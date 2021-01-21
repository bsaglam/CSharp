using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B15.ODEV
{
    class Musteri
    {
        public int Id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string mailAdresi { get; set; }
        private string _kullaniciAdi { get; set; }
        public string password { get; set; }
        public static ArrayList musteriList;
        static Musteri()
        {
            musteriList = new ArrayList();
        }


        public string KullaniciAdi
        {
            get { return _kullaniciAdi; }
            set { _kullaniciAdi = ControlUserName(value); }
        }

        private string ControlUserName(string value)
        {
            foreach (Musteri item in Musteri.musteriList)
            {
                if (item.KullaniciAdi == value)
                {
                    Console.WriteLine("Bu kullanıcı adı kullanılmaktadır.");
                    System.Threading.Thread.Sleep(2000);
                    return String.Empty;
                }

            }
            return value;
        }

        public static void MusteriEkle(Musteri musteri)
        {
            if (musteri != null)
            {
                //email adresi var mı kontrol et.
                foreach (Musteri item in musteriList)
                {
                    if (item.mailAdresi == musteri.mailAdresi)
                    {
                        Console.WriteLine("Mail adresi kayıtlıdır. Sisteme kaydedilememiştir.");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }
                }

                musteriList.Add(new Musteri
                {
                    Id = musteri.Id,
                    isim = musteri.isim,
                    soyisim = musteri.soyisim,
                    mailAdresi = musteri.mailAdresi,
                    KullaniciAdi = musteri.KullaniciAdi,
                    password = musteri.password
                });
            }


        }
    }
}
