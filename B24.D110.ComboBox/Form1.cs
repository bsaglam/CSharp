using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D210.ComboBoxOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //comboDoldur1();
            comboDoldur2();

        }

        private void comboDoldur2()
        {
            cbxUrun.DataSource = DataBase.urunListe; //yine TOString override edilmeli
        }

        private void comboDoldur1()
        {
            foreach (Urun item in DataBase.urunListe)
            {
                cbxUrun.Items.Add(item); // bu şekilde object görünlemesini istiyorsak, 
                                         //görüntülenecek objenin ToString metodunu override 
                                         //etmeliyiz
            }
        }

        private void cbxUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            Urun urun = cbx.SelectedItem as Urun;

            txtKategori.Text = urun.Kategori;
            txtStok.Text = urun.Stok.ToString();
            txtUrunAdi.Text = urun.Adi;
            txtYazar.Text = urun.Yazar;
            rtxtAciklama.Text= urun.Aciklama;
            pictureBox1.Image = Image.FromFile(urun.Resim);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
             
        }
    }
}
