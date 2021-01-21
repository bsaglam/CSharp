using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D197.FormaVeriGonderme
{
    public partial class MerhabaForm : Form
    {
        public MerhabaForm(string data)
        {
            InitializeComponent();
            label1.Text = data;

        }

        private void MerhabaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
