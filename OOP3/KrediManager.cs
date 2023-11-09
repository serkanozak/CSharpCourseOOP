using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager //interface'ler I ile başlar. okunurluğu artırmak açısından.
    {
        void Hesapla();
        void BirSeyYap();

    }

    //interface aslında şablon ve referans tutucudur.
    //interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.

    //KrediManager diğer tüm kredi türleri için aslında base görevi görüyür. Bu parent. 
    //Ancak her kredi türünün faiz oranı, dosya masrafı gibi farklı metodları var.
    //Dolayısıyla KrediManager içerisinde oluşturucağım bir metot, tüm kredi türlerime uygulanamayacak.
    //Bu noktada ŞABLON görevi gören ve yalnızca metod olarak tanımlanan interface devreye girer.
    //Ayrıca, bir class interface kullanıyorsa, MUTLAKA interface içerisinde tanımlanan metodu kullanmak zorunda.

    //interface'ı implamente eden class'ların her biri örneğin Hesapla(); metodunu farklı şekilde kullanabilir.
    //KonutKrediManager'da Hesapla(); metodunu başka bir faiz hesaplatmak için kullanırken,
    //IhtiyacKrediManager'da aynı metod olan Hesapla(); metodunu başka bir faiz hesaplatmak için kullanabiliriz.
    //Önemli olan interface'i implamente etmesidir. Tüm kredi türleri aynı metodu kullanarak farklı şekilde çalışacaktır.
}
