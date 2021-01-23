using System;

namespace Ornek4
{
    class Program
    {
        /* Araç türüne göre Otopark ücreti hesaplama */
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-) Taksi");
                Console.WriteLine("2-) Minibüs");
                Console.WriteLine("3-) Ticari araç");
                Console.Write("Araç Türünü Seçiniz: ");                
                int secim = Convert.ToInt32(Console.ReadLine());
                Console.Write("Saat giriniz: ");
                int saat = Convert.ToInt32(Console.ReadLine());
                Hesapla(secim,saat);
            }            
        }            
        static void Hesapla(int secim,int saat)
        {          
            switch (secim)
            {
                case 1: double sabit = 5; double degisken = sabit + (sabit * 0.2); double toplam = (1*sabit) + ((saat-1)*degisken); 
                    Console.WriteLine("Ücret: {0} YTL ",toplam); break;
                case 2: double sabit1 = 6; double degisken1 = sabit1 + (sabit1 * 0.215); double toplam1 = (1 * sabit1) + ((saat - 1) * degisken1);
                    Console.WriteLine("Ücret: {0} YTL ", toplam1); break;
                case 3: double sabit2 = 6.5; double degisken2 = sabit2 + (sabit2 * 0.25); double toplam2 = (1 * sabit2) + ((saat - 1) * degisken2);
                    Console.WriteLine("Ücret: {0} YTL ", toplam2); break;
                default:
                    Console.WriteLine("Farklı seçim yaptınız");
                    break;
            }
        }
        
    }
   

}
