using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D220.CheckedListBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedList= (CheckedListBox)sender;
            if (e.NewValue == CheckState.Checked)
            {
                Urun urun = checkedList.Items[e.Index] as Urun;
                txtUrunAdi.Text = urun.Adi;
                txtKategori.Text = urun.Kategori;
                txtYazar.Text = urun.Yazar;
                txtStok.Text = urun.Stok.ToString();
                rtxtAciklama.Text = urun.Aciklama;
                pictureBox1.Image = Image.FromFile(urun.Resim);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckboxListDoldur();
        }

        private void CheckboxListDoldur()
        {
            foreach (var item in DataBase.urunListe)
            {
                checkedListBox1.Items.Add(item);
            }
           
        }
    }
}
