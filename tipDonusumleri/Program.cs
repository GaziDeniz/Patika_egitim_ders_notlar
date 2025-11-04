using System;
namespace tipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("Implicit Conversion:");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Hello ";
            char f = 'W';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("\nExplicit Conversion:");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // ToString Method
            Console.WriteLine("\nToString Method:");

            int num = 6;
            string strNum = num.ToString();
            Console.WriteLine("strNum: " + strNum);

            float floatNum = 12.5f;
            string strFloat = floatNum.ToString();
            Console.WriteLine("strFloat: " + strFloat);

            // System.Convert
            Console.WriteLine("\nSystem.Convert:");

            string str1 = "10";
            string str2 = "20";
            int int1 = Convert.ToInt32(str1);
            int int2 = Convert.ToInt32(str2);
            int sum = int1 + int2;
            Console.WriteLine("Sum: " + sum);

            // Parse Method
            Console.WriteLine("\nParse Method:");

            string parseStr1 = "10";
            string parseStr2 = "10.25";
            int parseInt = Int32.Parse(parseStr1);
            double parseDouble = Double.Parse(parseStr2);
            Console.WriteLine("parseInt: " + parseInt);
            Console.WriteLine("parseDouble: " + parseDouble);
        }
    }
}
