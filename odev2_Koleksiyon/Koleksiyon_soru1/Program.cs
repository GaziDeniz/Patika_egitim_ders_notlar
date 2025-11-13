//Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
//(ArrayList sınıfını kullanara yazınız.)
//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
using System;
using System.Collections;
namespace Koleksiyon_soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalListesi = new ArrayList();
            ArrayList asalOlmayanListesi = new ArrayList();
            int sayi;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
                bool isNumeric = int.TryParse(Console.ReadLine(), out sayi);
                if (!isNumeric || sayi <= 0)
                {
                    Console.WriteLine("Geçersiz giriş!");
                    i--;
                    continue;
                }
                if(sayi==1)
                    {
                        asalOlmayanListesi.Add(sayi);
                    }
                for(int j=2;j<sayi;j++)
                {
                    if(sayi%j==0)
                    {
                        asalOlmayanListesi.Add(sayi);
                        break;
                    }
                }
                if(!(asalOlmayanListesi.Contains(sayi)))
                {
                    asalListesi.Add(sayi);
                }
            }

            asalListesi.Sort();
            asalListesi.Reverse();
            asalOlmayanListesi.Sort();
            asalOlmayanListesi.Reverse();
            double asalToplam=0;
            double asalOlmayanToplam=0;
            int a=asalListesi.Count;
            int ao=asalOlmayanListesi.Count;
            Console.WriteLine("Asal sayılar listesi:");
            foreach(var item in asalListesi){Console.Write(item+" ");}
            Console.WriteLine(" ");
            Console.WriteLine("Asal olmayan sayılar listesi:");
            foreach(var item in asalOlmayanListesi){Console.Write(item+" ");}
            Console.WriteLine(" ");
            for(int i=0;i<asalListesi.Count;i++)
            {
                asalToplam+=(int)asalListesi[i];
            }
            for(int i=0;i<asalOlmayanListesi.Count;i++)
            {
                asalOlmayanToplam+=(int)asalOlmayanListesi[i];
            }
            
            Console.WriteLine("Asal sayıların sayısı:{0}, ortalaması:{1}:",a,(asalToplam/a).ToString("0.00"));
            Console.WriteLine("Asal olmayan sayıların sayısı:{0}, ortalaması:{1}:",ao,(asalOlmayanToplam/ao).ToString("0.00"));

        }
    }
}