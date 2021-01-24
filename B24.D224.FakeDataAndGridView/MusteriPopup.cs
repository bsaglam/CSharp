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
    public partial class MusteriPopup : Form
    {
        Musteri musteriData;
        public MusteriPopup(Musteri data)
        {
            InitializeComponent();
            musteriData = data;
        }

        private void MusteriPopup_Load(object sender, EventArgs e)
        {
            txtAd.Text = musteriData.Ad;
            txtSoyad.Text = musteriData.Soyad;
            txtTelefon.Text = musteriData.TelefonNumarası;
            txtMail.Text = musteriData.Email;
            txtSehir.Text = musteriData.City;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
