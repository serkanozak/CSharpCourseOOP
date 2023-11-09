using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        //syntax
        public void Ekle(Product product) // Ekle() içerisindeki Product --> veri tipi gibi düşün. product --> parametrenin alacağı değişken.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) // bu doğru olmayan kullanım.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);

        }
    }
}

