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
    public partial class UrunSecimForm : Form
    {
        List<Urun> urunListe = new List<Urun>();
        public UrunSecimForm(Urun[] urunListe)
        {  //bu form açılırken ürünlistesi ile beraber açılacak.
            InitializeComponent();
            this.urunListe = urunListe.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UrunSecimForm_Load(object sender, EventArgs e)// . Show çalışınca load metodu çalışıyor
        {
            //birden fazla seçimde açılan form, ürünlerin bilgileri ile açılacak.
            foreach (Urun item in urunListe)
            {
                Button btn = new Button();
                btn.Location = new System.Drawing.Point(3, 3);
                btn.Name = "button"+item.Id;
                btn.Size = new System.Drawing.Size(146, 53);
                btn.TabIndex = 0;
                btn.Text = item.Adi;
                btn.UseVisualStyleBackColor = true;
                //  burası ŞOKOMELLİ NOT, İTEM VERİLERİNİ BUTTON.TAG İLE SAKLAYABİLİRİZ.
                btn.Tag = item;
                //BURASIDA ŞOKOMELLİ DİNAMİK OLUŞTURULAN BU  BUTONLARA EVENT ATIYORUZ.
                btn.Click += Btn_Click;
                //Saatlerdir buton gözükmediği için uğraşıyorum. B buton FlowLayout üzerinde onun kontrolüne eklemem lazım
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //yapılan seçime göre açık olan formlardan ana forma, urun verileri ile geri dönecek.
            Form form = Application.OpenForms["Form1"];

            //gelen veriyi önce butona, sonra Urun nesnesine çevir.
            Button btn = (Button)sender;
            Urun urun = btn.Tag as Urun; // butonun Tag'ına Urun'u koymuştuk.

            //şimdi gelen veriyi formun içindeki öğelere tek tek atayacagız.
            //önce groupBox'a erişelim.
            GroupBox gb = (GroupBox)form.Controls["grpDetayBilgi"];
            //Groupbox'ın içindeki elemanlara erişelim.
            ((TextBox)gb.Controls["txtUrunAdi"]).Text = urun.Adi;
            ((TextBox)gb.Controls["txtKategori"]).Text = urun.Kategori;
            ((TextBox)gb.Controls["txtStok"]).Text = urun.Stok.ToString();
            ((TextBox)gb.Controls["txtYazar"]).Text = urun.Stok.ToString();
            ((RichTextBox)gb.Controls["rtxtAciklama"]).Text = urun.Aciklama;
            ((PictureBox)gb.Controls["pictureBox1"]).Image = Image.FromFile(urun.Resim);

            this.Close();
        }
    }
}
