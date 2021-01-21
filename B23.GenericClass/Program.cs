using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B23.GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m = new Musteri()
            {

                Id = 1,
                isim = "burcu",
                musteriNo = Guid.NewGuid(),
                soyisim = "sonmez"
            };
            GenericRepository<Musteri> repositoryMusteri = new GenericRepository<Musteri>();
            List<Musteri> liste = repositoryMusteri.Ekle(m);


            Urun urun = new Urun();
            urun.Id = 2;
            urun.UrunKodu = "abcddf";

            GenericRepository<Urun> repositoryUrun = new GenericRepository<Urun>();
            List<Urun> urunListem=repositoryUrun.Ekle(urun);

        }
    }
}
