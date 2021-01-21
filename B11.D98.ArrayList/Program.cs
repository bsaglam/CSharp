using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B11.D98.ArrayListe
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList array = new ArrayList();
            //array.Add("Burcu");
            //array.Add(20);

            //ArrayList array2 = new ArrayList();
            //array2.Add("eklenen");
            
            //array.AddRange(array2);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            #region 10 elemanlı arraylist i Z-A sıralaması olacak şekilde sıralayın
            ArrayList array1 = new ArrayList();
            array1.Add("Deneme");
            array1.Add("ali");
            array1.Add("ayşe");
            array1.Add("fikriye");
            array1.Add("özlem");
            array1.Add("Deneme");
            array1.Add("ece");
            array1.Add("sezgin");
            array1.Add("sevgi");
            array1.Add("eli");
            array1.Add("burcu");
            array1.Add("daniel");

            array1.Sort(); //bu aşamada datalar adan z ye sıralndı. indeksleri ter çevirisek ters sıralnış olur.
            array1.Reverse();
            
            /*neden bu fanteziye girdim bilmiyorum ama hazır bir fonk ile bu iş halleldilebilirdi.
             *
             * 
             * */

            //int length = array1.Count - 1;
            //for (int i = 0; i < length/2; i++)
            //{
            //    string temp=array1[i].ToString();
            //    array1[i] = array1[length];
            //    array1[length] = temp;
            //    length--;
            //}

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            #endregion
        }
    }
}
