using System;
namespace kurucu_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Karakter kar1=new Karakter();
            kar1.Ad="Hiram";
            kar1.Soyad="Abbas";
            kar1.Yas=63;
            kar1.Meslek="Kitapçı";

            kar1.karakterBilgileri();

            Karakter kar2=new Karakter("Gazi","Deniz",15,"Öğrenci");
            kar2.karakterBilgileri();

            Karakter kar3=new Karakter("Mehmet","Can");
            kar3.karakterBilgileri();


        }
    }

    class Karakter
    {
        public string Ad;
        public string Soyad;
        public int Yas;
        public string Meslek;

        public Karakter(){}

        public Karakter(string ad, string soyad,int yas, string meslek)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.Yas=yas;
            this.Meslek=meslek;
        }

        public Karakter(string ad, string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }

        public void karakterBilgileri()
        {
            Console.WriteLine("Karakterin adı:{0}",Ad);
            Console.WriteLine("Karakterin soyadı:{0}",Soyad);
            Console.WriteLine("Karakterin yaşı:{0}",Yas);
            Console.WriteLine("Karakterin mesleği:{0}",Meslek);
        }
    }
}