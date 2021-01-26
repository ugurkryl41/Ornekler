using System;

namespace Ornek14
{
    class Program
    {
        /* Girilen Kelimenin üçerli kombinasyonu bulan program */
        static void Main(string[] args)
        {
            Console.Write("Kelime Giriniz: ");
            string kelime = Console.ReadLine(); int uzunluk = 1;
            for (int i = 3; i <= kelime.Length; i++) { uzunluk *= i; }
            string ucerli; string[] kelimeler = new string[uzunluk];            

            Random rast = new Random();
            for (int i = 0; i < uzunluk;i++)
            {
                string ilk = kelime[Convert.ToInt32(rast.Next(0, kelime.Length))].ToString();
                string ikinci = kelime[Convert.ToInt32(rast.Next(0, kelime.Length))].ToString();
                while (true)
                {
                    if (ikinci == ilk)
                    {
                        ikinci = kelime[Convert.ToInt32(rast.Next(0, kelime.Length))].ToString();
                    }
                    else
                    {
                        break;
                    }
                }
                string ucuncu = kelime[Convert.ToInt32(rast.Next(0, kelime.Length))].ToString();
                while (true)
                {
                    if (ucuncu == ilk || ucuncu == ikinci)
                    {
                        ucuncu = kelime[Convert.ToInt32(rast.Next(0, kelime.Length))].ToString();
                    }
                    else   {  break;  }
                }
                bool kontrol = true;    ucerli = ilk + ikinci + ucuncu;
                foreach (var item in kelimeler)
                {
                    if (ucerli == item)  { kontrol = false;   }
                }
                if (kontrol == true)
                {
                    kelimeler[i] = ucerli;
                    Console.WriteLine(ucerli);
                }                
            }
            Console.WriteLine("Bitti");
        }
    }
}
