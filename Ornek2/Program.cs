using System;
using System.Collections;

namespace Ornek2
{
    class Program
    {
        /* Girilen Sayının,1 ve kendisi hariç asal çarpanlarının kareleri toplamı*/
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            ArrayList carpan = new ArrayList();
            int temp = sayi;           
            for (int i = 2; i < sayi; i++)
            {
                if (temp % i == 0)
                {
                    temp /= i;
                    if (carpan.Contains(i) == false)
                    {
                        carpan.Add(i);
                    }                   
                }
            }
            int toplam = 0;
            for (int i = 0; i < carpan.Count; i++)
            {
                int faktoriyel=1;
                for (int j = 1; j <= (int)carpan[i]; j++)
                {
                    faktoriyel *= j;
                }
                toplam += faktoriyel;
            }
            Console.WriteLine("Asal çarpanlarının faktoriyel toplamı: {0}",toplam);
        }
    }
}
