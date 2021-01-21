using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14.D131.KapsullemeOdec
{
    class Musteri
    {
        /* 1-tckn private Field alanı olacak
         * -----set----
         * 2-11 hane kontrolü
         * 3-sadece rakam olacak
         * ----get----
         * 4-öncelikle okunmaz ayarlansın
         * 5-daha sonra 3 hanesi okunabilsin.
         */

        private string _tcKimlikNumarasi;
        public string TcKimlikNumarasi
        {
            get { return _tcKimlikNumarasi.Substring(0,2); }

            set { Control(value); }
        }

        private void Control(string value)
        {
            //2. Hane kontrolü
            if (value.Length==11 && value.All(char.IsNumber))
            {
                _tcKimlikNumarasi = value;
            }
            else
            {
                Console.WriteLine("Girdiğiniz kimlik numarası hatalı!");
                Console.ReadLine();
            }
        }
    }
}
