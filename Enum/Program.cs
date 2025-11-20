using System;
namespace enum_notlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Salı);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik=32;
            if(sicaklik<(int)HavaDurumu.Soğuk){Console.WriteLine("Bugün evde soba kenarında ısın");}
            else if(sicaklik<(int)HavaDurumu.Normal && sicaklik>(int)HavaDurumu.Soğuk){Console.WriteLine("Bugün sıkı giyin");}
            else if(sicaklik>(int)HavaDurumu.ÇokSıcak){Console.WriteLine("Bugün dışarı çıkma");}
            else if(sicaklik>(int)HavaDurumu.Sıcak && sicaklik<(int)HavaDurumu.ÇokSıcak){Console.WriteLine("Bugün hafif giyin");}
            else{Console.WriteLine("Bugün hava yürüyüş için çok uygun");}

        }
    }

    enum Gunler
    {
        Pazartesi=1,  //normalde 0'dan başlar fakat istenilen bir değer atanabilir.
        Salı,
        Çarşamba,
        Perşembe=15,  //atanan bir int değeri varsa sıralamayı o değerden devam ettirir.Yani çarşamba=3, perş=15, cuma=16
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        ÇokSoğuk=-10,
        Soğuk=5,
        Normal=17,
        Sıcak=27,
        ÇokSıcak=35
    }
}