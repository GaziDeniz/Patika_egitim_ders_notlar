// Yeni bir console uygulaması açarak bir 3 kolondan oluşan bir TODO uygulaması yazınız. 
// Uygulamada olması gereken özellikler aşağıdaki gibidir.
// Kart Ekle
// Kart Güncelle
// Kart Sil
// Kart Taşı
// Board Listeleme

//Kart İçeriği:
//Baslık
//Icerik
//Atanan Kisi (Takım üyelerişnden biri olmalı)
//Büyüklük (XS, S, M, L, XL)

//--Açıklama:--
//--Board TODO - IN PROGRESS - DONE kolonlarından oluşmalı.
//--Varsayılan olarak bir board tanımlı olmalı ve 3 tane de kart barındırmalı.(Kartlar herhangi bir line'da yani kolonda olabilir.)
//--Kartlar ancak takımdan birine atanabilir. Takımdaki kişiler ise varsayılan olarak tanımlanmalı.
//Takım üyeleri Dictionary kullanılarak key-value pair şeklinde ya da bir sınıf aracılığıyla tutulabilir.
//Kartlara atama yapılırken takım üyeleri ID leri ile atanacak. Yani kullanılacak yapının mutlaka bir ID içermesi gerekir.
//--Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.

//**Büyüklükler Enum olarak saklanmalı.
//Kart üzerinde gösterilirken XS olarak gösterilmeli.Giriş yapılırken kullanıcıdan 1 alınmalıdır.



//Takım üyeleri mevcut bir listede daha tanımlanmış olamlıdır.(Program içerisinde dinamik tanımlanmasına gerek yok.)
//Kart tanımlarken takım üyesinin ID'si istenmeli. Tanımlı bir ID değilse "Hatalı girişler yaptınız!" uyarısı ile işlem iptal edilebilir.

//NOT: Uygulamanın yapısı genel olarak aşağıdaki gibi olmalıdır:
//Board 3 tane Line dan oluşur.
//Her bir line bir kart listesi tutar
//Kartların büyüklükleri pre-defined olan bir enum'da tutulur.
//Kart sadece takım üyelerinden birine atanabilir.
//Takım üyeleri daha önceden varsayıla olarak tanımlanmış bir listede olmalı. Struct, class ya da bir koleksiyon kullanılabilir.

using System;
namespace Patika_Proje_2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: \n*****************************************");
            Console.WriteLine("(1) Board Listelemek \n(2) Board'a Kart Eklemek \n(3) Board'dan Kart Silmek \n(4) Kart Taşımak");
            while(true)
            {
                string Menu=Console.ReadLine();
                if(Menu=="1"){}
                else if(Menu=="2"){}
                else if(Menu=="3"){}
                else if(Menu=="4"){}
                else{Console.WriteLine("Yanlış giriş yaptınız, lütfen listeden seçiniz.");}
            }
        }
    }

    public class Board
    {
        private string Baslık;
        private string Icerik;
        private int AtananKisi;
        private Buyuklukler Buyukluk;   
        public static void Listele(){}
        public static void KartEkle(){}
        public static void KartGuncelle(){}
        public static void KartSil(){}
        public static void KartTasi(){}
    }
    public enum Buyuklukler
    {
        XS=1,
        S=2,
        M=3,
        L=4,
        XL=5
    }
}
// uygulamada istenilen özellikler anlaşılamamıştır, dolayısıyla tamamlanamamıştır....