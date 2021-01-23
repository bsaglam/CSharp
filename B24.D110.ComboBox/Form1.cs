using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D110.ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Urun item in DataBase.urunListe)
            {
                cbxUrun.Items.Add(item); // bu şekilde object görünlemesini istiyorsak, 
                                         //görüntülenecek objenin ToString metodunu override 
                                         //etmeliyiz



            }
        }
    }
}
