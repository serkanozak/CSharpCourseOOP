using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // metodlar, tekrar tekrar kullanılabilir kod bloklarıdır. 
            // Don't repeat yourself! - DRY - Clean Code - Best Practice
            // Class'lar da aslında birer veri tipidir. 
            // Class isimlendirmeleri pascalcase yazılır. her kelimenin ilk harfi büyük.

            Product product1 = new Product(); // class'ın bir örneği oluşturuldu. Product class'ına ait bir nesne oluşturduk.
                                              // class adını veri tipi gibi düşün. o class türünde değerler üreteceğiz.
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            // type-safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("---------------Metotlar---------------");


            // instance -- class örneği oluşturma. 
            // encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}