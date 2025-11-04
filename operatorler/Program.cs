using System;
namespace operatorler
{
    class program
    {
        static void Main(string[] args)
        {
            // atama , işlemli atama
            int x = 3;
            int y = 5;
            y = y + 2;
            Console.WriteLine(y);
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);
            x *= 3;
            y /= 3;
            Console.WriteLine(x);
            Console.WriteLine(y);

            // && ve             Mantıksal 
            // || veya           Operatörler

            bool isCorrect = true;
            bool isCompleted = false;

            if (isCorrect && isCompleted) { Console.WriteLine("Perfect!"); }
            if (isCorrect || isCompleted) { Console.WriteLine("Great!"); }
            if (isCorrect && !isCompleted) { Console.WriteLine("Fine"); }

            // İlişkisel operatorler 

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            // aritmetik operatorler

            int sayı1=98;
            int sayı2 = 7;
            int sonuc1 = sayı1 + sayı2;
            Console.WriteLine(sonuc1);
            int sonuc2 = sayı1 - sayı2;
            Console.WriteLine(sonuc2);
            int sonuc3 = sayı1 * sayı2;
            Console.WriteLine(sonuc3);
            int sonuc4 = sayı1 / sayı2;
            Console.WriteLine(sonuc4);
            int sonuc5 = sayı1%10;             // mod alma 
            Console.WriteLine(sonuc5);
        }
    }
}