using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D217.ListBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = DataBase.urunListe;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listbox tan seçim yapılınca seçimi yakalayıp detay bilgilerini tutmalıyız.
            ListBox list = (ListBox)sender;

            //NOT: burda çok ciddi bir hata yapmışım. saatlerdir gelen sender daki selecteditem sayısını bulmaya çalışıyorum
            //bu zaten bit tane olacak. ben selected sayısını listboxtan almalıyım.

            int sayi = listBox1.SelectedItems.Count;

            if (sayi > 1)
            {
                List<Urun> liste = new List<Urun>();
                foreach (Urun item in listBox1.SelectedItems)
                {
                    liste.Add(item);
                }
                

                UrunSecimForm form = new UrunSecimForm(liste.ToArray());
                form.Show();
            }
            else
            {
                Urun urun = list.SelectedItem as Urun;

                pictureBox1.Image = Image.FromFile(urun.Resim);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                txtKategori.Text = urun.Kategori;
                txtStok.Text = urun.Stok.ToString();
                txtUrunAdi.Text = urun.Adi;
                txtYazar.Text = urun.Yazar;
                rtxtAciklama.Text = urun.Aciklama;
                pictureBox1.Image = Image.FromFile(urun.Resim);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
