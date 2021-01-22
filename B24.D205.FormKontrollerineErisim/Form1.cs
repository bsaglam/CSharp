using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D205.FormKontrollerineErisim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (Control item in this.Controls)
            //{
            //    MessageBox.Show(item.Name);
            //}
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bütün verileri silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                //ElemanSil1(); //sırayla her bir elemena ulaşabiliriz.
                ElemanSil2();
            }
        }

        private void ElemanSil1()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = String.Empty;
                }
            }
        }

        //Form controllerine tek tek ulaşmak için
        private void ElemanSil2()
        {
            ((TextBox)this.Controls["txtIsim"]).Text = String.Empty;
            ((TextBox)this.Controls["txtEmail"]).Text = String.Empty;
            ((TextBox)this.Controls["txtTelefon"]).Text = String.Empty;
            txtTelefon.Text = String.Empty;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri()
            {
                Email = txtEmail.Text,
                isim = txtIsim.Text,
                Telefon = txtTelefon.Text
            };
            SanalDatabase.db.Add(musteri);
            ElemanSil2();
        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            frmOnizle onizle = new frmOnizle();
            ((TextBox)onizle.Controls["txtIsim"]).Text = txtIsim.Text;
            ((TextBox)onizle.Controls["txtEmail"]).Text = txtEmail.Text;
            ((TextBox)onizle.Controls["txtTelefon"]).Text = txtTelefon.Text;
            onizle.Show();

        }
    }
}
