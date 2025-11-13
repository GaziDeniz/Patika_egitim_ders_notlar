/*Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
her iki grubun kendi içerisinde ortalamalarını alan 
ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran 
programı yazınız. (Array sınıfını kullanarak yazınız.)*/
using System;
using System.Collections;
namespace koleksiyon_soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList kucuk3 =new ArrayList();
            ArrayList buyuk3 =new ArrayList();
            ArrayList liste =new ArrayList();
            for(int i=0;i<20;i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz:",i+1);
                liste.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var item in liste)
            {
                Console.Write(item+" ");
            }
            
            liste.Sort();
            for(int i=0;i<3;i++)
            {
                kucuk3.Add(liste[i]);
            }
            liste.Reverse();
            for(int i=0;i<3;i++)
            {
                buyuk3.Add(liste[i]);
            }
            double k3=0;
            double b3=0;
            for(int i=0;i<3;i++)
            {
                k3+=(int)kucuk3[i];
            }
            liste.Reverse();
            for(int i=0;i<3;i++)
            {
                b3+=(int)buyuk3[i];
            }
            
            Console.WriteLine("En küçük 3 sayının ortalaması:{0}; en büyük 3 sayının ortalaması:{1}; ortalama toplamları:{2}",
            (k3/3).ToString("0.00"),
            (b3/3).ToString("0.00"),
            (k3+b3)/3);
        }
    }
}