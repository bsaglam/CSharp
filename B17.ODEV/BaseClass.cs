using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B17.ODEV
{
    public class BaseClass
    {
        private static int sayac = 1;
        private int _id; //kullanıcı dışarıdan veri atayamayacak ise kapsülleme yaparız. private belirleyicide
        public BaseClass()
        {
            _id = sayac;  //bu atamayı properties alanında private oldugundan yapamıyoruz.
            sayac++;
        }
        public int Id
        {
            get { return _id; }
            private set { }
        }

        public DateTime Olusturulmatarih { get; set; }
        public string OlusturanKullanici { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public string GuncelleyenKullanici { get; set; }
        public bool Silindi { get; set; }
        private string _barkod;
        public string barkod //barkodun ürünler içinde unique oldugu kontrol edilmelidir.
        {
            get{ return _barkod; }
            set
            {
                bool sonuc = SanalDatabase.BarkodControl(value);
                if (!sonuc)
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Aynı barkod numaralı ürün eklenmiştir.");
                }
            }
        }

        protected void Yaz()
        {
            Console.WriteLine("BaseClassMetodyum");
        }
    }
}
