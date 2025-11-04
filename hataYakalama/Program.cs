using System;
using System.Collections.Generic;
namespace hataYakalama
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayı: " + sayi);
            }
            catch (FormatException)
            {
                Console.WriteLine("Hata: Geçersiz format. Lütfen bir sayı giriniz.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Hata: Girilen sayı çok büyük veya çok küçük.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Beklenmeyen bir hata oluştu: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program sonlandı.");
            }
        }
    }
}