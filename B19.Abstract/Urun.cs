using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19.Abstract
{
    public class Urun : TemelSinif
    {
        public Urun()
        {
            // protected tanımlı parametreye normal kalıtım kuralllarına göre erişebiliyor.
        }

        public override void AbstractSample()
        {
            Console.WriteLine("Bu metod kalıtılan sınıfın iinde olan abstarct oldugu için, urun içinde tanımlamak zorundayıdm");
        }
         
    }
}
