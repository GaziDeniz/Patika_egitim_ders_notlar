using System;
namespace kalitim
{
    public class Hayvanlar:Canlilar
    {
        protected void HayvansalIcgudu()
        {
            Console.WriteLine("Bu canlı icgüdüleriyle yiyeceğe ulaşmak,korunmak veya eş bulmak için gelişmiş kas ve iskelet sistemleriyle hareket eder. ");
        }


// ortak olduğu halde bazı sınıflarda baskılanacak özelliği override ile cağırıyoruz
        protected override void UyaranaTepki()
        {
            base.UyaranaTepki();
            Console.WriteLine("Bu canlı temas kurduğunda duruma göre farklı tepkiler verebilir.");
        }
    }
    public class MemeliHayvanlar:Hayvanlar
    {
        public MemeliHayvanlar()
        {
            base.HayvansalIcgudu();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.Ureme();
            base.UyaranaTepki();
        }
        public void Dogurma()
        {
            Console.WriteLine("Bu canlı doğurarak çoğalır ve yavrularını sütle besler.");
        }
    }
    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.HayvansalIcgudu();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.Ureme();
            base.UyaranaTepki();
        }
        public void Yumurtlama()
        {
            Console.WriteLine("Bu canlı yumurtlayarak çoğalan bir hayvandır.");
        }
    }
}