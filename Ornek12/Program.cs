using System;

namespace Ornek12
{
    class Program
    {
        /* Girilen 10 kelimeden uzun kelimeyi bulan kod */
        static void Main(string[] args)
        {
            string[] metin = new string[10];

            for (int i = 0; i < metin.Length; i++)
            {
                Console.Write("Metin girin: ");
                string kelime = Console.ReadLine();
                metin[i] = kelime;
            }
            int indexx = 0; int karakter = 0;   string enuzun="";
            for (int i = 0; i < metin.Length; i++)
            {                
                if (karakter < metin[i].Length)
                {
                    karakter = metin[i].Length;     indexx = i;
                    enuzun = metin[i].ToString();
                }
            }
            Console.WriteLine("En uzun kelime: "+enuzun.ToString()+" karakter sayısı: "+karakter+" index no: "+indexx);
        }
    }
}
