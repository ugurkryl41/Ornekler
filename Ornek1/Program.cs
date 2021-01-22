using System;

namespace Ornek1
{
    /* Girilen 3 basamaklı sayının basamaklarına ayıran örnek */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int yuzler = sayi / 100;
            sayi -= yuzler * 100;
            int onlar = sayi / 10;
            sayi -= onlar * 10;
            int birler = sayi / 1;

            Console.WriteLine("Yuzler: {0} , Onlar: {1} , Birler: {2}",yuzler,onlar,birler);
        }
    }
}
