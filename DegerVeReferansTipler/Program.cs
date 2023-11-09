using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ? --> 30

            // int, decimal, float, double, bool gibi sayısal veri tipleri değer tiplerdir.
            // bellekte stack ve heap adında 2 alan var. 
            // değer tipinde tanımlama yaptığımızda bu stack alanında saklanıyor.
            // burada sayi1'in değeri sayi2'nin değerine eşittir şeklinde okunur. 
            // sayi2'de eşitlemeden sonra yapılan değişiklikler sayi1'in değerini artık etkileyemez. 

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ? --> 999

            // array, class, interface referans tiplerdir.
            // int[] sayilar1 bu kısım stack'te saklanır. 
            // ancak devamında new dediğimiz anda heap'te bir alan açılır ve sayilar1 için gelecek değerleri o alanda saklar.
            // buradaki stack ile heap arasındaki bağlantı ise adres numaraları ile sağlanır.
            // örneğin, sayilar1'in stack'teki adresi 101 ise heap'deki 101 adresini tutar.
            // dolayısıyla sayilar1'in dataları 101. adreste.

            // sayilar2 adında bir array tanımladığımızda, sayilar2 stack'te, tuttuğu veriler heap'te saklanır.
            // sayilar2 bellekten bir adres alır. örneğin 102. artık sayilar2'in stack'teki ve heap'teki adresi 102.
            // bu noktada, 23. satır şu şekilde okunur; sayilar1'in referans numarası sayilar2'in referans numarasına eşittir. 
            // artık sayilar1'in adresi 101 değil, 102 olur. Dolayısıyla sayilar1'in heap'teki verileri aslında 102. adresteki veriler.
            // bu sebeple 102. adresteki verilerde yapılan değişikliklerden sayilar1'de etkilenecektir.
        }
    }
}
