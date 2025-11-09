using System;
namespace stringMethodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";

            // Length
            Console.WriteLine(degisken.Length);

            // ToUpper / ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat
            Console.WriteLine(string.Concat(degisken, " Merhaba!"));

            // Compare / CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0, 1, -1
            Console.WriteLine(string.Compare(degisken, degisken2, true)); // true ignore case(büyük küçük harf duyarsız-tam tersi olması isteniyorsa false yapılır)

            // Contains
            Console.WriteLine(degisken.Contains(degisken2));

            // IndexOf
            Console.WriteLine(degisken.IndexOf("CSharp"));
            Console.WriteLine(degisken.IndexOf("csharp")); // -1

            // Insert
            Console.WriteLine(degisken.Insert(0, "Hello! "));// 0. indexten itibaren ekler

            // PadLeft / PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadRight(30, '*'));

            // Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));

            // Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));

            // Split
            string[] kelimeler = degisken.Split(' ');
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            // Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
        }
    }
}
