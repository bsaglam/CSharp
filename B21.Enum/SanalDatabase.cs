using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B21.Enum
{
    public class SanalDatabase
    {
        ArrayList liste = new ArrayList();
        public ReturnValue EkleMusteri(Musteri musteri)
        {
            liste.Add(musteri);
            return ReturnValue.success;
        }


    }
}
