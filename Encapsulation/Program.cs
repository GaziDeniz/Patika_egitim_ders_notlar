using System;
using System.Security.Cryptography;
namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisiler kisi1=new Kisiler();
            kisi1.AdSoyad="ramazan taşkesen";
            kisi1.Numara=3371188;
            kisi1.Sinif=5;
            kisi1.KisiBilgileriYazdir();

            kisi1.SinifAtlat();
            kisi1.KisiBilgileriYazdir();

            Kisiler kisi2=new Kisiler("Muhittin Bilen",3961678,2);
            kisi2.SinifDusur();
            kisi2.SinifDusur();
            kisi2.KisiBilgileriYazdir();

        }
    }
    class Kisiler
    {
        private string adSoyad;
        private int numara;
        private int sinif;

        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public int Numara { get => numara; set => numara = value; }
        public int Sinif 
        { 
            get => sinif; 
            set 
            {
                if(value<1)
                {
                    Console.WriteLine("Sınıf en düşük 1 olabilir!");
                    sinif=1;
                }
                else{sinif = value;}
            } 
        }

        public Kisiler(string adSoyad, int numara, int sinif)
        {
            AdSoyad = adSoyad;
            Numara = numara;
            Sinif = sinif;
        }

        public Kisiler(){}

        public void KisiBilgileriYazdir()
        {
            Console.WriteLine("**********Kişi Bilgileri**********");
            Console.WriteLine("Ad-Soyad:{0}",this.AdSoyad);
            Console.WriteLine("Numara  :{0}",this.Numara);
            Console.WriteLine("Sınıf   :{0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }
        public void SinifDusur()
        {
            this.Sinif -= 1;
        }
    }
}
