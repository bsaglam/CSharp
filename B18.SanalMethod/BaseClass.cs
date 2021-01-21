using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18.SanalMethod
{
    public class BaseClass
    {
        public virtual void EkranaYaz(string data)
        {
            Console.WriteLine("BaseClass" + data);
        }
    }
}
