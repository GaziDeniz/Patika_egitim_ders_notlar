using System;
namespace dizi_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort etme işlemi
            int[] sayilar = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine("***** Sıralama Öncesi *****");
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();

            Array.Sort(sayilar);
            Console.WriteLine("***** Sıralama Sonrası *****");
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();

            //Clear metodu
            Console.WriteLine("***** Clear Metodu *****");
            Array.Clear(sayilar, 3, 1); // sayilar dizisinin 3. elemanı itibariyle 1 elemanı 0 yapar
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();

            //Reverse metodu
            Console.WriteLine("***** Reverse Metodu *****");
            Array.Reverse(sayilar);
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();

            //IndexOf metodu
            Console.WriteLine("***** IndexOf Metodu *****");
            int index = Array.IndexOf(sayilar, 72);
            if (index != -1)
            {
                Console.WriteLine("72 sayısı dizinin {0}. indeksinde bulunuyor.", index);
            }
            else
            {
                Console.WriteLine("72 sayısı dizide bulunamadı.");
            }

            //Resize metodu
            Console.WriteLine("***** Resize Metodu *****");
            Array.Resize(ref sayilar, 12);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i] + " ");
            }
            Console.WriteLine(); 

            //veya

            Array.Resize<int>(ref sayilar, 15);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i] + " ");
            }   
        }
    }
}
