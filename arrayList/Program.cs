using System;
using System.Collections;
namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();

            liste.Add("Mirsat");
            liste.Add("Keten");
            liste.Add(35);
            liste.Add(true);
            liste.Add('S');

            Console.WriteLine(liste[0]);
            //veya
            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            string[] isimler = { "Roxanne", "Sherry", "Miria", "Vesta", "Lutina" };
            List<int> sayılar = new List<int>() { 17, 16, 15 };

            liste.AddRange(isimler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort metodu ile işlem yapmak yazma sırasında hata vermese de derleme esnasında hem string hem int hem char gibi
            //farklılıklardan dolayı çalışmayacağını unutmamak gerekir

            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            liste.Clear();
        }
    }
}