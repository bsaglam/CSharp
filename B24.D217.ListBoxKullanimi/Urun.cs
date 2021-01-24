using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B24.D217.ListBoxKullanimi
{
    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Yazar { get; set; }
        public int Stok { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }
        public string Kategori { get; set; }

        public override string ToString()
        {
            return Adi.ToString();

        }
    }
}
