using System;
namespace struck
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dortgen1=new Dikdortgen();   //daha büyük alan kapsar
            dortgen1.a=3;                           //değer belirtilmeden alan hesaplanırsa değerler otomatik olarak 0 atanır
            dortgen1.b=4;
            Console.WriteLine(dortgen1.AlanHesabi());
            

            DikdortgenStruct dortgen2;              //daha küçük alan kaplar
            dortgen2.c=3;                           // new kullanılmadan oluşturulabilir
            dortgen2.d=4;                           //değer ataması yapılmazsa hata verir otomatik olarak 0 atamaz
            Console.WriteLine(dortgen2.AlanHesabi());

        }
    }
    class Dikdortgen
    {
        public int a;   // kısa kenar
        public int b;   // uzun kenar

        /*                               //class içinde parametre belitmeden kurucu metotda değer atanabilir
        public Dikdortgen()
        {
            a=3;
            b=4;
        }
        */

        public long AlanHesabi()
        {
            return a*b;
        }

    }
    struct DikdortgenStruct
    {
        public int c;   // kısa kenar
        public int d;   // uzun kenar

        public long AlanHesabi()
        {
            return c*d;
        }
    }
}