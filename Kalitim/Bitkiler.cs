using System;
namespace kalitim
{
    public class Bitkiler:Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bu canlı besinlerini kendileri güneş ışığı yardımıyla üretir.");
        }

        // ortak olduğu halde bazı sınıflarda baskılanacak özelliği override ile cağırıyoruz
        //baskılamak istediğimiz özelliği kapatıp yeni bir kod ekleyebiliriz
        protected override void UyaranaTepki()
        {
            //base.UyaranaTepki();
            Console.WriteLine("Bu canlı güneş ışığına tepki verir.");
        }
    }

    public class CicekliBitkiler:Bitkiler
    {
        public CicekliBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.Ureme();
            base.UyaranaTepki();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Bu canlı tozlaşma yardımıyla tohum üretir ve bununla çoğalır.");
        }
    }
    public class CiceksizBitkiler:Bitkiler
    {
        public CiceksizBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.Ureme();
            base.UyaranaTepki();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Bu canlı eşeyli çoğalma ile spor üretir ve bununla çoğalır.");
        }
    }
}