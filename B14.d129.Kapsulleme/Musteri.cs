using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14.d129.Kapsulleme
{
    class Musteri
    {
        public string isim;
        private string email;
        public Musteri()
        {
            email = "burcu.sonmez@hotmail";
        }
        public string Email
        {
            get { return email; }

            private set { email = value; } //dışardan erişilemsin istiyorsak set kısmını private yaparız.
        }
    }
}
