using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();//tipi kurs olan kurs1 in var artık
            kurs1.kursAdi = "c#";
            kurs1.Egitmen = "berna özgen";
            kurs1.izlenmeOrani = 68;


            Kurs kurs2 = new Kurs();//tipi kurs olan kurs2 in var artık
            kurs2.kursAdi = "java";
            kurs2.Egitmen = "Kerem Varay";
            kurs2.izlenmeOrani = 64;


            Kurs kurs3 = new Kurs();//tipi kurs olan kurs3 in var artık
            kurs3.kursAdi = "python";
            kurs3.Egitmen = "engin demiroğ";
            kurs3.izlenmeOrani = 98;


            Kurs kurs4 = new Kurs();//tipi kurs olan kurs3 in var artık
            kurs4.kursAdi = "c++";
            kurs4.Egitmen = "Murat kurtboğan";
            kurs4.izlenmeOrani = 100;

            // Console.WriteLine(kurs1.kursAdi + " " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3,kurs4 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi+" "+kurs.Egitmen+" "+kurs.izlenmeOrani);
            }
        }
    }
    class Kurs
    {
        public  string kursAdi { get; set; }
        public  string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }

    }
}
