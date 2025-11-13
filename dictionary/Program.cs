using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kisiler = new Dictionary<int, string>();

            kisiler.Add(1, "Monkey D Luffy");
            kisiler.Add(2, "Roronoa Zoro");
            kisiler.Add(3, "Nami");
            kisiler.Add(4, "Usopp");
            kisiler.Add(5, "Sanji");
            kisiler.Add(6, "Tony Tony Chopper");
            kisiler.Add(7, "Nico Robin");
            kisiler.Add(8, "Franky");
            kisiler.Add(9, "Brook");
            kisiler.Add(10, "Jinbe");
            kisiler.Add(11, "Nefertari Vivi");

            Console.WriteLine(kisiler[3]);
            foreach (var kisi in kisiler)
            {
                Console.WriteLine(kisi);
            }

            //count ve contains örnekleri(countains bool döner)

            Console.WriteLine(kisiler.Count);
            Console.WriteLine(kisiler.ContainsKey(7));
            Console.WriteLine(kisiler.ContainsValue("Nami"));   

            kisiler.Remove(11);  //vivi silindi.
        }
    }
}