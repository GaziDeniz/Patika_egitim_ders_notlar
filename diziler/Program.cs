using System;
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hayvanlar = new string[5] { "Kedi", "Köpek", "Tavşan", "Kuğu", "At" };
            int[] dizi;
            dizi = new int[5];
            string[] renkler = new string[5];
            renkler[1] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(renkler[1]);
            Console.WriteLine(dizi[3]);

            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz:", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Dizinin elemanlarının toplamı: " + toplam);
        }
    }
}