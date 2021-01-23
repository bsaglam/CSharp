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
    public partial class frmOnizle : Form
    {
        public frmOnizle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Bu kaydet butonuna bastıgımda, açık olan formlar arasından bir önceki formu bulup ona geçiş yapabilmeli
            // bunun için Application.Openforms 'u kullanabiliriz.

            foreach (Form item in Application.OpenForms) //Form ları sırasıyla geziyorum
            {
                if (item.Name == "Form1") //Geçş yapacağım formu buluyorum
                {
                    foreach (Control itemControl in item.Controls) //geçiş yapcağım formun controllerine erişip, null yapıyorum
                    {
                        if (itemControl is TextBox)
                        {
                            ((TextBox)itemControl).Text = String.Empty;
                        }
                    }
                }
            }
            this.Close();//açık olan formu kapatıyorum.
        }
    }
}
