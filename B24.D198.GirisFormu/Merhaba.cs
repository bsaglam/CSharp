using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D198.GirisFormu
{
    public partial class Merhaba : Form
    {
        public Merhaba(Kullanici kullanici)
        {
            InitializeComponent();
            txtIsim.Text = kullanici.isim;
            txtKullaniciAdi.Text = kullanici.kullaniciAdi;
            txtKullaniciAdi.Enabled = false;
            txtSifre.Text = kullanici.sifre;
            btnGuncelle.Tag = kullanici.Id;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //ben burda kullanıcı adından yakaladım. peki ya ID'ye ihtiyacımız olsa idi.
            Button btn = (Button)sender;
            int id = (int)btn.Tag;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string isim = txtIsim.Text;
            string aciklama = txtAciklama.Text;

            Kullanici istenenKullanici = SanalDatabase.KullaniciTablo.Find(x => x.kullaniciAdi == kullaniciAdi);

            istenenKullanici.isim = isim;
            istenenKullanici.sifre = sifre;
            istenenKullanici.aciklama = aciklama;
            MessageBox.Show("bilgiler güncellenmiştir","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
