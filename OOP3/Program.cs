using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekranlar acılır pencere gibi dusun 
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();
            //ekranda cagırma yapacagımız yerler 
            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService= new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

           // basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerServic);
            //basvuruManager.BasvuruYap(ıhtiyacKrediManager,fileLoggerService);

            List<ILoggerService> logger = new List<ILoggerService>() { smsLoggerService, databaseLoggerService }; //ekranda secilen logları aldı varsayılıyor.        
            basvuruManager.BasvuruYap(esnafKrediManager, logger);
            List<ILoggerService> loggers = new List<ILoggerService>() { smsLoggerService, fileLoggerService };
            basvuruManager.BasvuruYap(konutKrediManager,loggers);


            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,tasitKrediManager};//ekrandan secilenleri liste tutup birden fazla hesaplama yaparız
           //basvuruManager.KrediOnBilgilendirmesiYap(krediler); 
        }
    }
}
