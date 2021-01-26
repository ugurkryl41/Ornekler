using System;

namespace Ornek13
{
    class Program
    {
        /* Girilen kelimenin sesli harf kontrolu 0 tane sesli veya hepsi sesli harf ise tekrar kelime isteyen kod. */
        static void Main(string[] args)
        {
            Console.WriteLine("Kelime girin: ");
            string kelime = Console.ReadLine();
            bool kontrol = true;
            while (kontrol == true)
            {
                int sayac = 0;
                for (int i = 0; i < kelime.Length; i++)
                {
                    if (kelime[i] == 'a' || kelime[i] == 'A') { sayac++; }
                    if (kelime[i] == 'e' || kelime[i] == 'E') { sayac++; }
                    if (kelime[i] == 'o' || kelime[i] == 'O') { sayac++; }
                    if (kelime[i] == 'ö' || kelime[i] == 'Ö') { sayac++; }
                    if (kelime[i] == 'ı' || kelime[i] == 'I') { sayac++; }
                    if (kelime[i] == 'i' || kelime[i] == 'İ') { sayac++; }
                    if (kelime[i] == 'u' || kelime[i] == 'U') { sayac++; }
                    if (kelime[i] == 'ü' || kelime[i] == 'Ü') { sayac++; }
                }
                if (sayac < kelime.Length && sayac != 0)
                {
                    kontrol = false;
                }
                else
                {
                    Console.WriteLine("Tekrardan Kelime giriniz: ");
                    kelime = Console.ReadLine();    kontrol = true;
                }
            }

        }
    }
}
