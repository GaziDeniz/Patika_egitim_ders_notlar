using System;
namespace kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            CiceksizBitkiler egreti=new CiceksizBitkiler();
            egreti.SporlaCogalma();
            Console.WriteLine("-------------------------------------");
            MemeliHayvanlar insan=new MemeliHayvanlar();
            insan.Dogurma();
        }
    }
}