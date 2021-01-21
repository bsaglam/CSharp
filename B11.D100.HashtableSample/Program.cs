using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B11.D100.HashtableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = String.Empty;
            Hashtable table = new Hashtable();
            do
            {
                Console.WriteLine("Eklemek istediğiniz ing kelimeyi giriniz.");
                string eng = Console.ReadLine();
                bool control = table.Contains(eng);

                if (control)
                {
                    Console.WriteLine("Eklediğiniz kelime sözlükte bulunmaktadır. Başka bir kelime ekleyiniz.");
                }
                else
                {
                    Console.WriteLine("Karşılığı olan Türkçe kelimeyi giriniz.");
                    string tr = Console.ReadLine();
                    table.Add(eng, tr);
                    Console.WriteLine("{0}-{1} değerleri sözlüğe eklenmiştir.", eng, tr);
                }
                
                Console.WriteLine("Kelime Eklemeye devam etmek istiyor musunuz?(E/H)");
                result = Console.ReadLine().ToUpper();
            }
            while (result == "E");
            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine("{0}-{1}",item.Key,item.Value);
            }
            Console.ReadLine();

        }
    }
}
