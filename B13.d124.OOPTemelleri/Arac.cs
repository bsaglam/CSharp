using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B13.d124.OOPTemelleri
{
    class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int ModelYili { get; set; }
        public decimal Km { get; set; }
        public int YakitTipi { get; set; }
        public int VitesTipi { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public decimal MaxIndirim { get; set; }
        public decimal Fiyat { get; set; }

        public void BilgileriGoruntule()
        {

        }

        public void FiyatAta(decimal SatisFiyati,decimal maxIndirimTutari)
        {
            decimal minFiyat = SatisFiyat - maxIndirimTutari;

            if (minFiyat>0)
            {

            }
        }
    }
}
