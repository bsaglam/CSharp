using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B17.ODEV
{
    public class Urun : BaseClass
    {
        //Kurallar
        /**
         * 1. AlisFiyat >0
         * 
         * 2.AlisFiyat>satisfiyat
         * 
         * 3.Kampanya>0
         * 
         * 4.Sadece seçilen markalarda değerler eklenebilir.
         *
         */
        // Ozaman bbu field lara kapsülleme yapacağız.
        private decimal _alisFiyat;
        private decimal _kampanyafiyat;
        private decimal _satisFiyat;
        public string Marka { get; set; }
        public string Model { get; set; }
       
        public decimal SatisFiyat {

            get { return _satisFiyat;}
            set
            {
                if (value>_alisFiyat)
                {
                    _satisFiyat = value;
                }
                else
                {
                    Console.WriteLine("satış fiyatı alış fiyatından küçük olamaz.");
                }
            }
        }
        public decimal KampanyaFiyat {

            get { return _kampanyafiyat; }
            set
            {
                if (value>0)
                {
                    _kampanyafiyat = value;
                }
                else
                {
                    Console.WriteLine("kampanya fiyatı 0 dan küçük olamaz.");
                }
            }

        }

        public decimal AlisFiyat {

            get { return _alisFiyat; }

            set
            {
                if (value > 0)
                {
                    _alisFiyat = value;
                }
                else
                {
                    Console.WriteLine("alış fiyatı 0 dan küçük olamaz.");
                }
            }

        }
    
      
    }
}
