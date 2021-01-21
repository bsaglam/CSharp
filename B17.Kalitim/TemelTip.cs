using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B17.Kalitim
{
    public class TemelTip
    {
        public int Id { get; set; }
        public string ReferansKod { get; set; }
        public string TcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public string kayitGüncelle { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public string guncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public TemelTip()
        {
            IdAtama();
        }

        private void IdAtama()
        {
            Random random = new Random();
            Id=random.Next(1000,9000);
        }

        public void TemelTipMetodu()
        {
            Console.WriteLine("Temel tip içindeki public method");
        }


    }
}
