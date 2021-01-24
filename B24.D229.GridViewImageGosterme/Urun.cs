using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B24.D229.GridViewImageGosterme
{
    public class Urun
    {
        public int Id { get; set; }
        public String UrunTanim { get; set; }
        public string ResimYol { get; set; }
        public Image Resim
        {
            get
            {
                if (string.IsNullOrEmpty(ResimYol))
                {
                    return Image.FromFile(ResimYol);
                }
                else
                {
                    return Image.FromFile(@"C:\Users\GMYLOJ59\Desktop\Keys-icon.png");
                }

            }
        }
    }
}
