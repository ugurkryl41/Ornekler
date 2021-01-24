using System;

namespace Ornek5
{
    class Program
    {
        /* Girilen sayının en büyük rakamını bulan kod*/
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            string sayi1 = Convert.ToString(sayi);

            int enb = Convert.ToInt32(sayi1[0].ToString());

            for (int i = 1; i < sayi1.Length; i++)
            {
                if (enb<Convert.ToInt32(sayi1[i].ToString()))
                {
                    enb = Convert.ToInt32(sayi1[i].ToString());
                }
            }

            Console.WriteLine("En Büyük Rakam: "+enb);
        }
    }
}
