using System;

namespace kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double DolarBugun = 7.45;

            if (dolarDun > DolarBugun)
            {
                Console.WriteLine("dolar azaldı");
            }
            else if (dolarDun<DolarBugun)
            {
                Console.WriteLine("dolar artmış");
            }
            else
            {
                Console.WriteLine("dolar degişmedi");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();
        }
    }
}
