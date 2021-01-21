using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B17.ODEV
{
    public static class SanalDatabase
    {
        private static ArrayList db = new ArrayList();

        public static void UrunEkle(BaseClass model)
        {
            if(model != null && !String.IsNullOrEmpty(model.barkod))
            {
                db.Add(model);
            }
        }
        public static bool BarkodControl(string barkod)
        {
            bool result = false;
            foreach (BaseClass item in  db)
            {
                if (item.barkod == barkod)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

    }
}
