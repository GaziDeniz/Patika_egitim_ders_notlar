using System;
using System.Reflection.Metadata;
namespace rekursifveExtensionMethod
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Rekürsif - Öz Yinelemeli
            int result = 1;
            for (int i = 1; i <= 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            islemler islem = new islemler();
            Console.WriteLine(islem.Expo(3, 5));

            // Extension Metotlar
            string ifade = "Bom Bili Bili Bili Bom Booom Bom Bili Bili Bili Bom";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
            dizi.EkranaYazdir();
            dizi = dizi.SortArray();
            dizi.EkranaYazdir();    

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

        }
    }
    public class islemler
        {
            public int Expo(int sayi, int üs)
            {
                if (üs < 2)
                    return sayi;
                return Expo(sayi, üs - 1) * sayi;
            }
        }

    public static class Extensions
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int GetFirstCharacter(this string param)
        {
            return param.Length;
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param, int number)
        {
            return param.Substring(0, number);
        }
    }
}