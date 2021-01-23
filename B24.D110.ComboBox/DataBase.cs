using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B24.D110.ComboBox
{
    public static class DataBase
    {
        public static List<Urun> urunListe;

        static DataBase()
        {
            urunListe = new List<Urun>()
            {
                new Urun(){Id=1,Adi="karamamov kardeşler",Resim="",stok=10,Yazar="Dostoyevski",Aciklama="aladmmfdısfkldsmflkdmsfdıfmkdv mdd csdllkdkf"},
                new Urun(){Id=1,Adi="beyaz zambaklar ülkesinde",Resim="",stok=10,Yazar="Balzac",Aciklama="aladmmfdısfkldsmflkdmsfdıfmkdv mdd csdllkdkf"},
                new Urun(){Id=1,Adi="aşk",Resim="",stok=10,Yazar="Elif Şafak",Aciklama="aladmmfdısfkldsmflkdmsfdıfmkdv mdd csdllkdkf"}
            };
        }
    }
}
