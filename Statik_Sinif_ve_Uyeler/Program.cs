using System;
namespace statikSinifveUyeler
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);
            Calisan isci1=new Calisan("Frederic","Hudson","IT");
            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);

            Console.WriteLine("toplama işlemi sonucu: {0}",Islemler.Topla(598,155));
            Console.WriteLine("carpma işlemi sonucu: {0}",Islemler.Carp(598,155));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi;} //read only hali(seti sildik)
        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi=0;   //ilk calısma esnasında calisan sayısı 0 olarak belirlendi.
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;   // her bir calısan eklendiğinde sayı 1 artacak
        }
    }

    static class Islemler
    {
        public static long Topla(int a, int b)
        {
            return a+b;
        }
        public static long Carp(int a, int b)
        {
            return a*b;
        }
    }
}