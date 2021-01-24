using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B24.D224.FakeDataAndGridView
{
    public class DataBase
    {
        public List<Musteri> listMusteri = new List<Musteri>();

        public List<Musteri> MusteriGetir()
        {
            for (int i = 1; i < 10001; i++)
            {
                Musteri musteri = new Musteri();
                musteri.Id = i;
                musteri.Ad = FakeData.NameData.GetFirstName();
                musteri.Soyad = FakeData.NameData.GetSurname();
                musteri.Email = FakeData.NetworkData.GetEmail(musteri.Ad, musteri.Soyad);
                musteri.TelefonNumarası = FakeData.PhoneNumberData.GetPhoneNumber();
                musteri.City = FakeData.PlaceData.GetCity();
                listMusteri.Add(musteri);
            }
            

            return listMusteri;
        }
    }
}
