using System;
namespace Odev_1_Algoritmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
            int n = int.Parse(Console.ReadLine());
            int[] sayilar = new int[n];
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Lütfen dizi elemanlarını oluşturmak için pozitif bir sayı giriniz:");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Oluşturulan dizi: "+string.Join(", ", sayilar));
            Console.WriteLine("Çift sayılar:");
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            }

            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (k, m).  
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine("Lütfen pozitif 2 adet sayı giriniz:");
            int k = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] sayilar2 = new int[k];
            for (int i=0; i<k; i++)
            {
                Console.WriteLine("Lütfen dizi elemanlarını oluşturmak için pozitif bir sayılar giriniz:");
                sayilar2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Oluşturulan dizi: "+string.Join(", ", sayilar2));
            Console.WriteLine("m'e eşit veya tam bölünen sayılar:");
            foreach (int sayi2 in sayilar2)
            {
                if (sayi2 == m || sayi2 % m == 0)
                {
                    Console.WriteLine(sayi2);
                }
            }

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
            int p = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[p];
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine("Lütfen bir kelime giriniz:");
                kelimeler[i] = Console.ReadLine();
            }
            Console.WriteLine("Girdiğiniz kelimeler (sondan başa):");
            Array.Reverse(kelimeler);
            Console.WriteLine(string.Join(", ", kelimeler));

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Lütfen bir cümle yazınız:");
            string cumle = Console.ReadLine();
            string[] kelimeler2 = cumle.Split();
            int sayac = 0;
            foreach (var item in kelimeler2)
            {
                sayac++;
            }
            Console.WriteLine("Cümledeki kelime sayısı: " + sayac);
            int toplamHarf = 0;
            foreach (var item in kelimeler2)
            {
                toplamHarf += item.Length;
            }
            Console.WriteLine("Cümledeki toplam harf sayısı: " + toplamHarf);
        }
    }
}