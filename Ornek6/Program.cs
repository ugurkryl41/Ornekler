using System;

namespace Ornek6
{
    /* ilk dizi elemanına yakın sayıyı bulan ornek*/
    class Program
    {
        static void Main(string[] args)
        {
            Random rast = new Random();
            int[] sayidizi = new int[10];

            for (int i = 0; i < sayidizi.Length; i++)
            {
                sayidizi[i] = rast.Next(100);
                Console.Write(sayidizi[i]+",");
            }

            Console.WriteLine("");

            int enyakin=0, fark=Int32.MaxValue;
            for (int i = 1; i < sayidizi.Length; i++)
            {
                if (Math.Abs(sayidizi[0] - sayidizi[i]) < fark)
                {
                    fark = Math.Abs(sayidizi[0] - sayidizi[i]);
                    enyakin = sayidizi[i];
                }
            }
                     
            Console.WriteLine("İlk elemana yakın sayı {0}",enyakin);
        }
    }
}
