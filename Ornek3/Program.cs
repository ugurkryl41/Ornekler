using System;
using System.Collections;

namespace Ornek3
{
    class Program
    {
        /* Girilen cümlenin Kelime ve Karakter tekrarı sayısını bulan örnek */ 
        static void Main(string[] args)
        {
            Console.Write("Cümle giriniz: ");
            string cumle = Console.ReadLine().ToString();
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime sayısı: {0}",kelimeler.Length);

            ArrayList karakter = new ArrayList();
            ArrayList tekrarsayisi = new ArrayList();

            for (int i = 0; i < cumle.Length; i++)
            {
                if (karakter.Contains(cumle[i]) == false)
                {
                    karakter.Add(cumle[i]);
                    tekrarsayisi.Add(1);
                }
                else
                {
                    tekrarsayisi[karakter.IndexOf(cumle[i])] = Convert.ToInt32(tekrarsayisi[karakter.IndexOf(cumle[i])]) + 1 ;
                }
            }
            for (int i = 0; i < karakter.Count; i++)
            {
                Console.WriteLine("{0} Karakter Sayısı {1}",karakter[i],tekrarsayisi[i]);
            }
        }
    }
}
