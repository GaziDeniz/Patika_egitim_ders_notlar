using System;
namespace sinif_Kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //class SınıfAdı
            //{
            //      [Erişim Belirleyici] [Veri Tipi] Özellik_Adı:
            //      [Erişim Belirleyici] [Geri dönüş tipi] Metot_adı(Parametre listesi)
            //          {
            //              Metot komutları
            //          }
            //}


            // ERİŞİM BELİRLEYİCİLER
            // public
            // private
            // internal
            // protected


            Karakter kar1=new Karakter();
            kar1.Ad="Hiram";
            kar1.Soyad="Abbas";
            kar1.Yas=63;
            kar1.Meslek="Kitapçı";

            kar1.karakterBilgileri();


        }
    }

    class Karakter
    {
        public string Ad;
        public string Soyad;
        public int Yas;
        public string Meslek;

        public void karakterBilgileri()
        {
            Console.WriteLine("Karakterin adı:{0}",Ad);
            Console.WriteLine("Karakterin soyadı:{0}",Soyad);
            Console.WriteLine("Karakterin yaşı:{0}",Yas);
            Console.WriteLine("Karakterin mesleği:{0}",Meslek);
        }
    }
}