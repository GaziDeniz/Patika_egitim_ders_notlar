using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
namespace Patika_Proje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rehber> Rehberim=new List<Rehber>();
            Rehber r1=new Rehber();
            r1.Kisi="Ev";
            r1.No="04221112233";
            Rehberim.Add(r1);
            Rehber r2=new Rehber();
            r2.Kisi="İş";
            r2.No="02424445566";
            Rehberim.Add(r2);
            Rehber r3=new Rehber();
            r3.Kisi="M.Keten";
            r3.No="05368889900";
            Rehberim.Add(r3);
            Rehber r4=new Rehber();
            r4.Kisi="Bakkal";
            r4.No="05555555555";
            Rehberim.Add(r4);
            Rehber r5=new Rehber();
            r5.Kisi="Hanım";
            r5.No="05384567890";
            Rehberim.Add(r5);


            while(true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \n (1) Yeni Numara Kaydetmek \n (2) Varolan Numarayı Silmek \n (3) Varolan Numarayı Güncelleme \n (4) Rehberi Listelemek \n (5) Rehberde Arama Yapmak \n");
            
                string Tuslama=Console.ReadLine();
                if(Tuslama=="1"){Rehber.Ekle(Rehberim);}
                else if(Tuslama=="2"){Rehber.Sil(Rehberim);}
                else if(Tuslama=="3"){Rehber.Guncelle(Rehberim);}
                else if(Tuslama=="4"){Rehber.Listele(Rehberim);}
                else if(Tuslama=="5"){Rehber.Bul(Rehberim);}
                else if(Tuslama=="0"){Console.WriteLine("Programdan çıkılıyor....");}
                else{Console.WriteLine("Yanlış giriş; lütfen listeden bir numara seçin!");}
            }
        }
    }

    public class Rehber
    {
        private string kisi;
        private string no;

        public string Kisi { get => kisi; set => kisi = value; }
        public string No { get => no; set => no = value; }

        public static void Ekle(List<Rehber> myrehber)
        {
            Rehber r=new Rehber();
            Console.WriteLine("Numarayı giriniz: ");
            r.No=Console.ReadLine();
            Console.WriteLine("Kişi adı giriniz: ");
            r.Kisi=Console.ReadLine();
            myrehber.Add(r);
            Console.WriteLine("{0} kişisi eklendi..",r.Kisi);
        }
        public static void Sil(List<Rehber> myrehber)
        {
            Console.WriteLine("Silmek istediğiniz kişiyi giriniz: ");
            string aranacak=Console.ReadLine().ToLower();
            Rehber bulunan=myrehber.FirstOrDefault(item=>item.Kisi.ToLower().Contains(aranacak));
            if(bulunan==null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n Silmeyi sonlandırmak için : (1) \n Yeniden denemek için      : (2)");
                string secim=Console.ReadLine();
                if(secim=="1") {return;}
                else if(secim=="2")
                {
                    Sil(myrehber);
                }
                else{Console.WriteLine("Yanlış giriş yapıldı.İşlem sonlandırılıyor...");}
            }
            else
            {
                Console.WriteLine("{0} kişisi silinmek üzere onaylıyor musunuz: (y)/(n)",bulunan.Kisi);
                string secim2=Console.ReadLine();
                if(secim2=="y")
                {
                    myrehber.Remove(bulunan);
                    Console.WriteLine("{0} kişisi silindi",bulunan.Kisi);
                }
                else if(secim2=="n"){return;}
                else{Console.WriteLine("Yanlış giriş yapıldı.İşlem sonlandırılıyor...");}
            }
        }
        public static void Guncelle(List<Rehber> myrehber)
        {
            Console.WriteLine("Değiştirmek istediğiniz kişiyi giriniz: ");
            string aranan=Console.ReadLine().ToLower();
            Rehber bulunan=myrehber.FirstOrDefault(item=>item.Kisi.ToLower().Contains(aranan));
            if(bulunan==null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Güncellemeyi sonlandırmak için    : (1) \n Yeniden denemek için              : (2)");
                string secim=Console.ReadLine();
                if(secim=="1"){return;}
                else if(secim=="2"){Guncelle(myrehber);}
                else{Console.WriteLine("Yanlış giriş yapıldı.İşlem sonlandırılıyor...");}
            }
            else
            {
                Console.WriteLine("{0} kişisi icin yeni numarayı giriniz: ",bulunan.Kisi);
                bulunan.No=Console.ReadLine();
                Console.WriteLine("{0} kişisine ait numara güncellenmiştir.",bulunan.Kisi);
            }
        }
        public static void Listele(List<Rehber> myrehber)
        {
            foreach (var item in myrehber)
            {
                Console.WriteLine(item.Kisi+" "+item.No);
            }
        }
        public static void Bul(List<Rehber> myrehber)
        {
            Console.WriteLine("Aramak istediğiniz kişi adı veya numarayı giriniz: ");
            string aranacak=Console.ReadLine().ToLower();
            foreach (var item in myrehber)
            {
                if(item.Kisi.ToLower().Contains(aranacak)||item.No.Contains(aranacak))
                {
                    Console.WriteLine(item.Kisi+" "+item.No);
                }
            }
        }
    }
}