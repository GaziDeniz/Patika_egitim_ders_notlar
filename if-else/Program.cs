using System;
namespace if_else   
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (time < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else
            {
                Console.WriteLine("Good evening!");
            }

            // veya şu şekilde de yazılabilir

            string sonuc = time < 12 ? "Good morning!" : time < 18 ? "Good afternoon!" : "Good evening!";
            Console.WriteLine(sonuc);
        }
    }
}   
