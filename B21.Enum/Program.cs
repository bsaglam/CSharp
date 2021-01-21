using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B21.Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.cs den bir personel bilgileri girilecek
            //Sanaldatabase de veri eklenecek
            //Sanal databaseden dönen enum değerlere göre program.cs te yönlendirilecek.1  
            Musteri m = new Musteri()
            {
                Id = 1,
                Name = "burc",
                Surname = "sonmez"
            };
            SanalDatabase sd = new SanalDatabase();
            ReturnValue result=sd.EkleMusteri(m);
            if (result==ReturnValue.failed)
            {
                Console.WriteLine("Başarısız kayıt");
            }
            else if (result == ReturnValue.success)
            {
                Console.WriteLine("Başrılı kayıt");
            }

        }
    }
}
