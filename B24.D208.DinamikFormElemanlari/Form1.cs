using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D208.DinamikFormElemanlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 50; i++)
            {
                Button btn = new Button();
                //btn.Location = new System.Drawing.Point(12, 12);
                btn.Name = "button" + i;
                btn.Size = new System.Drawing.Size(35, 35);
                btn.TabIndex = 0;
                btn.Text = i.ToString();
                btn.UseVisualStyleBackColor = true;
                flowLayoutPanel1.Controls.Add(btn);

            }
        }
    }
}
