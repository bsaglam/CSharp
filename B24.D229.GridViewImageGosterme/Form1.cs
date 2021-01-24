using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D229.GridViewImageGosterme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Urun> musteri = new List<Urun>() {
                new Urun{Id=1,ResimYol=@"C:\Users\GMYLOJ59\Desktop\Keys-icon.png",UrunTanim="aaaabbbcc"},
                new Urun{Id=2,ResimYol=@"C:\Users\GMYLOJ59\Desktop\Keys-icon.png",UrunTanim="bbbbbbbbb"},
                new Urun{Id=3,ResimYol=@"C:\Users\GMYLOJ59\Desktop\Keys-icon.png",UrunTanim="ccccccccc"},

            };
            dataGridView1.DataSource = musteri;
        }
    }
}
