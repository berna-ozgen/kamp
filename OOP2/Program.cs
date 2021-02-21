using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri1 = new GercekMusteri();
            gercekMusteri1.Id = 1;
            gercekMusteri1.MusteriNo = "123";
            gercekMusteri1.Adi = "Berna";
            gercekMusteri1.Soyadi = "Özgen";
            gercekMusteri1.TcNo = "12345678978";




            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "124";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456789";




            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            musteri3.Id = 12;
            musteri3.MusteriNo = "1234";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(gercekMusteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
            

        }
    }
}
