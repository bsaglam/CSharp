using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayitEklemeVeListeleme_Notify
{
    public static class SanalDatabase
    {
        public static List<Musteri> db;
        static SanalDatabase()
        {
            db = new List<Musteri>();
        }
    }
}
