using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19.Abstract
{
    public abstract class TemelSinif
    {
        public int id { get; set; }
        protected int deneme { get; set; }
        public TemelSinif()
        {
            id = 5;
        }
        public void normalMetod()
        {
            Console.WriteLine("Miras alan nesnenin çağırdıgı,Temel sınıf içinde sıradan bir metodum.");
        }
        public abstract void AbstractSample(); //abstract metodun body kısmı olmaz.

        
    }
}
