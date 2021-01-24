using System;
using System.Collections;

namespace Ornek7
{
    class Program
    {
        /* 1-10 arasında 1000 tane sayının frekansı hesaplayan ornek*/
        static void Main(string[] args)
        {
            Random rast = new Random();            
            int[] sayilar = new int[1000];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rast.Next(1, 10);
            }
            ArrayList liste = new ArrayList();
            ArrayList frekans = new ArrayList();
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (liste.Contains(sayilar[i]) == false)
                {
                    liste.Add(sayilar[i]);
                    frekans.Add(1);
                }
                else
                {
                    frekans[liste.IndexOf(sayilar[i])] = Convert.ToInt32(frekans[liste.IndexOf(sayilar[i])]) + 1;
                }
            }

            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine("{0} Frekans: {1}",liste[i],frekans[i]);
            }

          
            
        }
    }
}
