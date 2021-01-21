using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B15.Static
{
    class Personel
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        private string _email { get; set; }
        public static string domain = "@domain.com";
        public string Email
        {
            get { return _email; }

            set { _email = value.ToLower() + "@" + Personel.domain; }
        }

    }
}
