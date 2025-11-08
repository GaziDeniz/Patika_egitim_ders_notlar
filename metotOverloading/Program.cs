using System;
namespace metotOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc1 = Topla(4, 5);
            Console.WriteLine("Topla(int, int): " + sonuc1);

            int sonuc2 = Topla(4, 5, 6);
            Console.WriteLine("Topla(int, int, int): " + sonuc2);

            double sonuc3 = Topla(4.5, 5.5);
            Console.WriteLine("Topla(double, double): " + sonuc3);
        }

        static int Topla(int a, int b)
        {
            return a + b;
        }

        static int Topla(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Topla(double a, double b)
        {
            return a + b;
        }
    }
}
