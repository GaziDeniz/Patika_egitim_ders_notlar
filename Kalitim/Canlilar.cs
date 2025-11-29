using System;
namespace kalitim
{
    public class Canlilar   //bu sınıfın, hiçbir sınıf tarafından kalıtılmasını istemiyorsak public sealed class canlılar şeklinde tanımlayabilirdik.
    {
        protected void Beslenme()
        {
            Console.WriteLine("Bu canlı besine ihtiyaç duyar.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Bu canlı solunum yapar.");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Bu canlı boşaltım yapar.");
        }
        protected void Ureme()
        {
            Console.WriteLine("Bu canlı üreyerek çoğalır.");
        }

         //en üst sınıfta genel bir özellik,fakat bazı alt sınıflarda bu özelliği baskılamak veya değiştirmek istiyoruz isek;
         // virtual ile oluşturuyoruz
        protected virtual void UyaranaTepki() 
        {
            Console.WriteLine("Bu canlı kendisini dışardan uyaran bir etkiye tepki verir.");
        }
    }
}