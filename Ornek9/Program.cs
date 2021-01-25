using System;

namespace Ornek9
{
    class Program
    {
        /* Bir komisyoncu sattığı mallardan kazandığı toplam komisyonu veren ornek 
         * 50 YTL altındakilerden %3
         * 50 YTL üzeri ürünlerden %2 komisyon alınımaktadır.
         */
        static void Main(string[] args)
        {
            double toplamkomisyon=0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ücreti girin:");
                double sayi = Convert.ToDouble(Console.ReadLine());
                double komisyon = sayi >= 50 ? sayi * 2 / 100 : sayi * 3 / 100;
                Console.WriteLine("Komisyon: "+komisyon);
                toplamkomisyon += komisyon;
            }
            Console.WriteLine("Toplam komisyon"+Math.Round(toplamkomisyon,2));

        }
    }
}
