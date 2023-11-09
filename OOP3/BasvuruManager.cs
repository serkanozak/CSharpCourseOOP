using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) // bu metod içerisindeki parametre sayesinde hangi krediyi gönderirsek, o kredi türünün bellekteki hesapla metodu çalışır.
        {
            //Başvuran bilgilerini değerlendirme.
            //
            krediManager.Hesapla(); //hangi kredi türü verilirse, o kredinin Hesapla(); metodu çalışacak.
            /*loggerService.Log();*/ //sistemde hangi loglama sistemi seçildiyse onu logla.
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
