using KayitEklemeVeListeleme_Notify;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D202.KayitEklemeVeListeleme_Notify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string isim = txtIsim.Text;
            Guid id = Guid.NewGuid();
            string soyisim = txtSoyisim.Text;
            string email = txtEmail.Text;
            string sifre = txtSifre.Text;
            int result = MusteriEkle(new Musteri() { Isim = isim, Soyisim = soyisim, Email = email, Sifre = sifre,Id=id });

            if (result > 0)
            {
                DialogResult response = MessageBox.Show("Kayıt işlemi başarılı, Yeni bir kayıt daha eklemek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    bildirim = new NotifyIcon();
                    bildirim.BalloonTipText = "Toplam kayıt sayısı " + SanalDatabase.db.Count.ToString() + "olmuştur";
                    bildirim.BalloonTipTitle = "Kayıt sayısı";
                    bildirim.Visible = true;
                    bildirim.Icon = SystemIcons.Information;
                    bildirim.ShowBalloonTip(2000);
                    
                }

                EkraniTemizle();
                KayitListele();
            }
            else
            {
                MessageBox.Show("sistemsel bir hatadan dolayı kayıt başarısız.");
               
            }

        }

        private void KayitListele()
        {
            lstKayit.DataSource = null; //bunu eklemeden önce listbox güncellenmemişti. null yapıp daha sonra yeni veriyi ekledim.
            lstKayit.DataSource = SanalDatabase.db;// bu şekilde datasource'a listeyi direk ekelyince TOSTRING() metodunu isim soyisim döndürecek şekilde override ettik.
             
        }
        private void EkraniTemizle()
        {
            txtIsim.Text = String.Empty;
            txtSoyisim.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtSifre.Text = String.Empty;
        }

        private int MusteriEkle(Musteri m)
        {
            SanalDatabase.db.Add(m);
            return 1;
        }

         
    }
}
