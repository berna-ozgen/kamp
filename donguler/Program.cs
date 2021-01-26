using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            // array=diziler
            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı" , 
                "programlamaya başlangıç için temel kurs" ,
                "java","python","c++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti ----------------");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            
            Console.WriteLine("sayfa sonu");
            // class yapısı 
            




        }
    }
}
