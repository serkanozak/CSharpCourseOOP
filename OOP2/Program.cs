using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678901";


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri --> ikisi de müşteri ama birbiri yerine kullanılamaz.
            //SOLID - L

            Musteri musteri3 = new GercekMusteri(); // new gördüğün her yerde aklına ilk olarak referans no olduğu aklına gelsin. 
            Musteri musteri4 = new TuzelMusteri();
            //ÇOK ÖNEMLİ --> Musteri class'ı hem GercekMusteri'nin referansını hem de TuzelMusteri'nin referansını tutabiliyor.
            //Dolayısıyla CustomerManager classında metodun istediği Add(Musteri musteri) parametreleri bu şekilde gönderebiliriz.
            //Çünkü Musteri class'ı musteri1, musteri2, musteri3, musteri4 hepsini tutuyor. (referanslarını tuttuğu için)

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

            // eğer base class varsa (örnekte 'Musteri') o class referans tutucudur.



        }
    }
}
