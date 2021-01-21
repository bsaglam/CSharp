using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B15.Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            personel.isim = "Burcu";
            personel.soyisim = "Saglam";
            personel.Email = "burcu.saglam";

            Helper.MailGonder("ik@firma.com","yeni personel",personel.isim+personel.soyisim);
        }
    }
}
