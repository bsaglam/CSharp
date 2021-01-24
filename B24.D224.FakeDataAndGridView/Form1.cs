using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D224.FakeDataAndGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            List<Musteri> liste = db.MusteriGetir();
            //1. gelen listenin hepsini vermek istersek
            dgMusteriListe.DataSource = liste;



            // 2. Eğer gelen listeden sadece bazılarını göstermek istersek

            var dgList = from I in liste
                         select new
                         {
                             isim = I.Ad,
                             soyisim = I.Soyad,
                             MailAdresi = I.Email
                         };

            //burda ToList() yapmayı unutma!
            //dgMusteriListe.DataSource = dgList.ToList();

        }

        private void dgMusteriListe_DoubleClick(object sender, EventArgs e)
        {
            // gridde tıklanan row'un coloumn undaki değere ulaşma
            int sayi = (int)dgMusteriListe[0, dgMusteriListe.CurrentCell.RowIndex].Value;
            DataBase db = new DataBase();
            Musteri musteri = db.MusteriGetir().FindAll(x => x.Id == sayi).FirstOrDefault();
            MusteriPopup popup = new MusteriPopup(musteri);
            popup.Show();
        }
    }
}
