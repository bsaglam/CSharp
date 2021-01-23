using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24.D209.MayinTarlasi
{
    public partial class Form1 : Form
    {
        private static int sayac = 1;
        public Form1()
        {
            InitializeComponent();
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Tag.ToString().Length == 3)
            {
                btn.BackColor = Color.Red;
                if (sayac < 3)
                {
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Game Over");
                    Temizle();
                }

            }
            else
            {
                btn.BackColor = Color.Bisque;
            }
            btn.Enabled = false;
        }

        private void Temizle()
        {
            foreach (Button item in flowLayoutPanel1.Controls)
            {
                item.BackColor = Button.DefaultBackColor;
                item.Enabled = true;
            }
            sayac = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 64; i++)
            {
                Button btn = new Button();
                btn.Location = new System.Drawing.Point(3, 3);
                btn.Name = "button" + i.ToString();
                btn.Text = String.Empty;
                btn.Size = new System.Drawing.Size(30, 30);
                btn.TabIndex = 0;
                btn.UseVisualStyleBackColor = true;
                btn.Tag = random.Next(1, 150).ToString();
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);

            }
        }
    }
}
