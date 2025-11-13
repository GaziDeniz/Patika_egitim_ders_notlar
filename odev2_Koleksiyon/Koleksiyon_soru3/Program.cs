/*Klavyeden girilen cümle içerisindeki sesli harfleri 
bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.*/
using System;
using System.Collections;
using System.Linq;
namespace koleksiyon_soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cumleSeslileri={};
            char[] unluler={'a','e','ı','i','o','ö','u','ü','A','E','I','İ','O','Ö','U','Ü'};
            Console.WriteLine("Lütfen bir cümle yazınız:");
            string cumle=Console.ReadLine();
            foreach (char harf in cumle)
            {
                if(unluler.Contains(harf))
                {
                    Array.Resize(ref cumleSeslileri, cumleSeslileri.Length + 1);
                    cumleSeslileri[cumleSeslileri.Length - 1] = harf;
                }
            }
            Array.Sort(cumleSeslileri);
            Console.WriteLine("Cümledeki sesli harfler sıralanmış şekilde:");
            foreach (char sesli in cumleSeslileri)
            {
                Console.Write(sesli+" ");
            }
        }
    }
}
