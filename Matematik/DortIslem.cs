using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Toplama(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: " +toplam);
        }
        public void Cikarma(int sayi1,int sayi2)
        {
            int cikarma = sayi1 - sayi2;
            Console.WriteLine("sonuc: " + cikarma);

        }
        public void Bölme(int sayi1,int sayi2)
        {
            int bolum = sayi1 / sayi2;
            Console.WriteLine("bölüm : " +bolum);
        }
        public void capma(int sayi1,int sayi2)
        {
            int carp = sayi1 * sayi2;
            Console.WriteLine("carpım: " +carp);
        }
    }
}
