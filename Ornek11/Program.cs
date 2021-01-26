using System;

namespace Ornek11
{
    class Program
    {
        /* Random 20 sayısının aritmetik ortalamasından büyük olanların sayısını bulan kod.*/
        static void Main(string[] args)
        {
            Random rast = new Random();
            int[] sayidizi = new int[20];
            int toplam = 0;
            for (int i = 0; i < sayidizi.Length; i++)
            {
                sayidizi[i] = rast.Next(1000);
                toplam += sayidizi[i];
            }
            int aort = toplam / sayidizi.Length;

            int sayac = 0;
            for (int i = 0; i < sayidizi.Length; i++)
            {
                if (sayidizi[i] > aort)
                {
                    sayac++;
                }
            }
            Console.WriteLine("Aritmetik ort:  "+aort+" büyük olanların sayısı: "+sayac+" Küçük olanların sayısı: "+ (sayidizi.Length-sayac));
        }
    }
}
