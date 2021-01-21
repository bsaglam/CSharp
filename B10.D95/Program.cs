using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10.D95
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 20 elemanlı bir dizi oluşturalım. ve içine 1-10 arasında rasgele değer atayalım.İçinde kaç tane 4 geldiyse yazdıralım
            int[] dizi = new int[20];
            int sayac = 0;
            Random random = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = random.Next(1, 10);
                Console.WriteLine(dizi[i]);
                if (dizi[i].ToString().Contains("4"))
                {
                    sayac++;
                }
            }
            Console.WriteLine("{0} adet 4 bulunmaktadır.",sayac);
            Console.ReadLine();
            #endregion
        }
    }
}
