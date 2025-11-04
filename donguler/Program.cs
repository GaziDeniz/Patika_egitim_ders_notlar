using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }
            Console.WriteLine("Tek toplam: " + tekToplam);
            Console.WriteLine("Çift toplam: " + ciftToplam);

            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 10; i++)
            {
                if (i == 6)
                    continue;
                Console.WriteLine(i);
            }

            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Toplam: " + toplam);

            char character = 'a';
            do
            {
                Console.WriteLine(character);
                character++;
            } while (character <= 'z');

            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}