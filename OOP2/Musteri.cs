using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Musteri // classlar özellik ve operasyon tutar.
                  // özellik tuttuğumuz yerde operasyon, operasyon tuttuğumuz yerde özellik tutulmaz.
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }


        // ÖNEMLİ !! --> Eğer bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsam, 
        // o nesneye ait değilmiş gibi duruyorsa, orada SOYUTLAMA hatası yapıyoruz.
    }
}

