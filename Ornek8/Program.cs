using System;
using System.Collections;

namespace Ornek8
{
    class Program
    {
        /* 9 kisiyi rastgele ucerli gruplara ayırma*/
        static void Main(string[] args)
        {
            int[] kisiler = new int[9];
            ArrayList grup1 = new ArrayList();
            ArrayList grup2 = new ArrayList();
            ArrayList grup3 = new ArrayList();

            for (int i = 1; i < kisiler.Length+1; i++)
            {
                kisiler[i - 1] = i;
            }

            for (int i = 0; i < kisiler.Length; i++)
            {
                Console.Write(kisiler[i]+",");
            }

            Random rast = new Random();

            for (int i = 0; i < kisiler.Length;)
            {
                int sayi = rast.Next(0, 9);

                if (i<3)
                {
                    if (grup1.Contains(kisiler[sayi]) == false && grup2.Contains(kisiler[sayi]) == false && grup3.Contains(kisiler[sayi]) == false)
                    {
                        grup1.Add(kisiler[sayi]); i++;
                    }
                }
                if (i>=3 && i<6)
                {
                    if (grup1.Contains(kisiler[sayi]) == false && grup2.Contains(kisiler[sayi]) == false && grup3.Contains(kisiler[sayi]) == false)
                    {
                        grup2.Add(kisiler[sayi]); i++;
                    }
                }
                if (i>=6 && i<9)
                {
                    if (grup1.Contains(kisiler[sayi]) == false && grup2.Contains(kisiler[sayi]) == false && grup3.Contains(kisiler[sayi]) == false)
                    {
                        grup3.Add(kisiler[sayi]); i++;
                    }
                }                
                
            }
            Console.WriteLine("");
            Console.WriteLine("Gruplar");
            Console.Write("Grup1: ");
            for (int i = 0; i < grup1.Count; i++)
            {
                Console.Write(grup1[i]);
            }
            Console.WriteLine("");
            Console.Write("Grup2: ");
            for (int i = 0; i < grup2.Count; i++)
            {
                Console.Write(grup2[i]);
            }
            Console.WriteLine("");
            Console.Write("Grup3: ");
            for (int i = 0; i < grup3.Count; i++)
            {
                Console.Write(grup3[i]);
            }
        }
    }
}
