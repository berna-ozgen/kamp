using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Product[] urunler = new Product[] { urun1, urun2 };
            foreach (Product x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine("-----------------------------");

            }

            Console.WriteLine("-----------------------METOTLAR--------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);//metot çagırma 
            sepetManager.Ekle(urun2);//metot çagırma 
            sepetManager.Ekle2("armut","yeşil armut",12);//elle ekleme yapıyoruz Yanlışşş!!!


        }
    }
}
