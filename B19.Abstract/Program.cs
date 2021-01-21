using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19.Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TemelSinif t = new TemelSinif();*/ // Abstract class örneklenemez.
            Urun urun = new Urun(); //ürün örneklenirken önce temelClass daha sonra 
                                    //ise Urun ctor'ıan gelir, Urun belleğe çıkarken temel class ta atanan değerleri alarak çıkar.
            int id=urun.id;         // abstact class içindeki field a miras alan erişebilir.

            //protected field a normalde de nesnesi ile erişemiyordu.
            urun.normalMetod(); //içindeki normal metoda eriştik.
            urun.AbstractSample();
            Console.ReadLine();
        }
    }
}
