using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B11.D99
{
    class Program
    {
        static void Main(string[] args)
        {
            string secim = String.Empty;
            ArrayList liste = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("----Menü-----");
                Console.WriteLine("1- Ekle");
                Console.WriteLine("2- Listele");
                Console.WriteLine("3- Ara");
                Console.WriteLine("4- Düzenle");
                Console.WriteLine("5- Sil");
                Console.WriteLine("6- Çıkış");

                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Listeye eklemek istediğiniz değeri giriniz.");
                        string item = Console.ReadLine();
                        liste.Add(item);
                        Console.WriteLine("Listeye eklendi.");
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case "2":
                        Console.WriteLine("Dizi listeleniyor.");
                        foreach (var i in liste)
                        {
                            Console.WriteLine(i);
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "3":
                        Console.WriteLine("Aratmak istediğiniz değeri giriniz.");
                        string search = Console.ReadLine();
                        bool control = liste.Contains(search);
                        if (control == true)
                            Console.WriteLine("Listede bulunmaktadır");
                        else
                            Console.WriteLine("Listede bulunamadı");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "4":
                        Console.WriteLine("Düzenlemek istediğiniz değeri giriniz.");
                        string editting = Console.ReadLine();
                        int index = liste.IndexOf(editting);
                        Console.WriteLine("Güncel veriyi giriniz");
                        string newData = Console.ReadLine();
                        liste[index] = newData;
                        Console.WriteLine("veriniz güncellenmiştir.");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "5":
                        Console.WriteLine("Silmek istediğiniz datayı giriniz");
                        string deleting = Console.ReadLine();
                        int indexDeleting = liste.IndexOf(deleting);
                        liste.RemoveAt(indexDeleting);
                        Console.WriteLine("eleman silinmiştir.");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            } while (secim != "6");
        }
    }
}
