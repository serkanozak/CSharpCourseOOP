using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Individual
    //Bankada çalıştığını düşün. Tüzel ve gerçek müşterilerin var. İkisi birbirinden farklı özelliklere sahip olsa da, esasında ikisi de müşteridir.
    //Dolayısıyla, GercekMusteri --> parent'ı Musteri classıdır. 
    //GercekMusteri classının Musteri classındaki özellikleri ve/veya operasyonları kullanabilmesi için Musteri classını miras alır.
    //Buna inheritance denir.
    class GercekMusteri : Musteri
    {
        public string TcNo { get; set; } //Tc sayısal olmasına rağmen, Tc ile matematiksel işlemler yapmayacağız.
                                         //Farklı yazılım ortamlarında uyumlu olması açısından string tutmak daha faydalı.
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        // entity yazılan class'a operasyon yazılmaz. kod çalışır ama uygulamada hatalıdır.
        // müşterilere ait operasyonları ayrı bir class açarak (CustomerManager) gerçekleştir.
    }
}

