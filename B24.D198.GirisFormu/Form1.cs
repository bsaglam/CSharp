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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKAdi.Text;

            string sifre = txtSifre.Text;

            Kullanici bulunanKullanici = SanalDatabase.KullaniciTablo.Find(x => x.kullaniciAdi == kullaniciAdi && x.sifre == sifre);

            if (bulunanKullanici != null)
            {
                Merhaba merhaba = new Merhaba(bulunanKullanici);
                merhaba.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtKAdi_Enter(object sender, EventArgs e)
        {
            TextBox tb=(TextBox)sender; //Textbox a ulaşmaya çalışıyoruz.
            tb.BackColor = Color.Yellow; //ulaştıktan sonra değerini değişitiriyouruz.
        }

        private void txtKAdi_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }
    }
}
