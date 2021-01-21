using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D196.YeniFormClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //sender içinde olayı oluşturan form elementi yer alır
            //event ve event le ilgili bilgiler
        
            Merhaba merhaba = new Merhaba();
            merhaba.Show();
        }
    }
}
