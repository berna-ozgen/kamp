using System.Collections.Generic;

namespace OOP3
{
    class BasvuruManager
    {
        // Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //basvuran bilgilerini degerlendirme yaparz 
            krediManager.Hesapla();//Kredi bagımsız olarak hesaplama yapıyoruz.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
