using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi ="Rabia";
            musteri1.MusteriSoyadi = "ARSLAN";
            musteri1.Id = "258970";
            musteri1.HesapTuru = "Vadeli Hesap";

            Musteri musteri2 = new Musteri(); 
            musteri2.MusteriAdi ="Sinan";
            musteri2.MusteriSoyadi = "GÜL";
            musteri2.Id = "237690";
            musteri2.HesapTuru = "Vadeli Hesap";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi ="Aypars";
            musteri3.MusteriSoyadi = "GÜl";
            musteri3.Id = "214781";
            musteri3.HesapTuru = "Vadesiz Hesap";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
          
            MusteriManager musterimanager = new MusteriManager();
            Console.WriteLine("\\Müşteri Bilgisi Ekle//\n");
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);
            Console.WriteLine("\n\\Müsteri Bilgileri Listele//");
            musterimanager.Listele(musteriler);
            Console.WriteLine("\n\\Müsteri Bilgisi Silme //");
            musterimanager.Silme(musteriler);

            Console.ReadKey();


        }
    }
}
