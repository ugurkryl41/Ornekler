using System;

namespace Ornek10
{
    class Program
    {
        /* Girilen 3 sayıdan enbüyük ve en küçük bulan kod */
        static void Main(string[] args)
        {            
            int[] sayilar = new int[3];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Sayi girin");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
            }
            int enb=Int32.MinValue, enk=Int32.MaxValue;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]>enb)
                {
                    enb = sayilar[i];
                }
                if (sayilar[i]<enk)
                {
                    enk = sayilar[i];
                }
            }

            Console.WriteLine("En Büyük:"+enb+"En küçük:"+enk);
        }
    }
}
