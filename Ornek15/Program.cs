using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Ornek15
{

    class Program
    {
        /* Girilen int değeri int tipinde diziye donusturduk.*/
        static void Main(string[] args)
        {
            Console.Write("Sayi girin");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int[] sayidizi = new int[sayi.ToString().Length];
            
            for (int i = 0; i < sayi.ToString().Length; i++)
            {    
                int s1 = Convert.ToInt32(sayi.ToString()[i].ToString());
                sayidizi[i] = s1;
            }

            foreach (var item in sayidizi)
            {
                Console.Write((int)item+",");
            }
        }

    }
}
