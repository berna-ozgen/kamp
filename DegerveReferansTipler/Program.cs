using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 15;
            int sayi2 = 30;
            sayi1 = sayi2; // sayi1 sayi 2nin degerini alır
            sayi2 = 60;
            //sayi1=?   30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;// sayi2 nin referans aldıgı yeri gösterir .
            sayilar2[0] = 999;
            //sayilar1[0]=?   999

        }
    }
}
