using System;

namespace KendiCalismalarim
{
    class Program
    {
        static void Main(string[] args)
        {/*
            string ad, soyadi;
            int yas;
            Console.Write("adınız: ");
            ad = Console.ReadLine();
            Console.Write("soyadiniz: ");
            soyadi = Console.ReadLine();
            Console.Write("yaşınız: ");
            yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("merhaba " + ad + " " + soyadi);
            if (yas>=18)
            {
                Console.WriteLine("yaşınız 18 den büyük/eşit olduğu için sisteme girişiniz onaylanmıştır.");
            }
            else
            {
                Console.WriteLine("yaşınız 18 yaşından küçük olduğu için sisteme girişiniz reddedilmiştir.");
            }
            */
            int say1, say2, top;
            Console.Write("1.sayıyı giriniz: ");
            say1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayıyı giriniz: ");
            say2 = Convert.ToInt32(Console.ReadLine());
            top = say1 + say2;
            Console.WriteLine("1.sayi: " + say1+" " + "2.sayı: " + say2);
            Console.WriteLine("toplamları: " + top);
        }
    }
}
