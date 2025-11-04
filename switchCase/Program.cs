using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (DateTime.Now.Month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid Month");
                    break;
            }
            switch (DateTime.Now.Month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("It's Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("It's Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("It's Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("It's Autumn");
                    break;
                default:
                    Console.WriteLine("Invalid Month");
                    break;
            }
        }
    }
}