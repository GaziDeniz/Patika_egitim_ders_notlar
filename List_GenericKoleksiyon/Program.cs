using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Security.Cryptography;
namespace List_GenericKoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count özelliği ile eleman sayısını öğrenme
            Console.WriteLine("Sayı Listesi Eleman Sayısı: " + sayiListesi.Count);
            Console.WriteLine("Renk Listesi Eleman Sayısı: " + renkListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            //veya
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            // Remove: Belirtilen elemanı listeden çıkarır
            sayiListesi.Remove(4);

            // Contains: Belirtilen elemanın listede olup olmadığını kontrol eder
            bool varMi = sayiListesi.Contains(10);
            Console.WriteLine("10 sayısı listede var mı? " + varMi);

            //diziyi listeye çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Clear: Tüm elemanları listeden çıkarır
            sayiListesi.Clear();
            Console.WriteLine("Sayı Listesi Eleman Sayısı (Clear sonrası): " + sayiListesi.Count);

            //eleman ile indexe erişim
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı")); //indexini verir


            //liste içinde nesne tutma
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>{};

            Kullanıcılar Kullanıcı1 = new Kullanıcılar();
            Kullanıcı1.Isim = "Nami";
            Kullanıcı1.Soyisim = "CatBuglar";
            Kullanıcı1.Yas = 20;
            
            Kullanıcılar Kullanıcı2 = new Kullanıcılar();
            Kullanıcı2.Isim = "Nico";
            Kullanıcı2.Soyisim = "Robin";
            Kullanıcı2.Yas = 28;

            kullanıcıListesi.Add(Kullanıcı1);
            kullanıcıListesi.Add(Kullanıcı2);

            //veya

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar> { };
            yeniListe.Add(new Kullanıcılar() { Isim = "Boa", Soyisim = "Hancock", Yas = 30 });
            
            foreach(var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı bilgileri: {0} {1} {2}",kullanıcı.Isim,kullanıcı.Soyisim,kullanıcı.Yas.ToString());
            }

        }
    }
    
    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
        
    }
}