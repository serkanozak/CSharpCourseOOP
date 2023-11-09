using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Coorporate
    //Bankada çalıştığını düşün. Tüzel ve gerçek müşterilerin var. İkisi birbirinden farklı özelliklere sahip olsa da, esasında ikisi de müşteridir.
    //Dolayısıyla, TuzelMusteri --> parent'ı Musteri classıdır. 
    //TuzelMusteri classının Musteri classındaki özellikleri ve/veya operasyonları kullanabilmesi için Musteri classını miras alır.
    //Buna inheritance denir.
    class TuzelMusteri : Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
