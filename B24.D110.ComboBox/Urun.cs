using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B24.D110.ComboBox
{
    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Yazar { get; set; }
        public int stok { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }

        public override string ToString()
        {
            return Adi.ToString();

        }
    }
}
