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

            if ((bool)btn.Tag==true)
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
            //Butonlarımız oluşruken içine mayın olanları yerleştirmemiz gerekiyor.
            //Mayın oldugundan emin olmak içinde 50 yi 3 lü gruba ayıralım.
            int rnd1 = random.Next(1,20);
            int rnd2 = random.Next(21,40);
            int rnd3 = random.Next(41,50);
            for (int i = 0; i < 64; i++)
            {
                Button btn = new Button();
                if (rnd1==i || rnd2==i || rnd3 ==i)
                {

                    btn.Tag = true;
                }
                else btn.Tag = false;
                btn.Location = new System.Drawing.Point(3, 3);
                btn.Name = "button" + i.ToString();
                btn.Text = String.Empty;
                btn.Size = new System.Drawing.Size(30, 30);
                btn.UseVisualStyleBackColor = true;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);

            }
        }
    }
}
