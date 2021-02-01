using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       public void Ekle(Musteri musteri)
       {
            Console.WriteLine("Ad-Soyad: "+musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            Console.WriteLine("Id: " + musteri.Id + "\nHesap turu: " + musteri.HesapTuru+"\n");
       }
        public void Listele(Musteri[] musteriler)
        {
            for (int i = 0; i < musteriler.Length ; i++)
            {
                Console.WriteLine("---{0}. Müsteri---",i+1);
                Console.WriteLine(musteriler[i].MusteriAdi + " " + musteriler[i].MusteriSoyadi+ "\n"+
                musteriler[i].Id+ "\t"+musteriler[i].HesapTuru);

            }
        }
        public void Silme(Musteri[] musteriler)
        {
            Console.Write("Bilgileri silinecek müşterinin indisini giriniz: ");
            int indis = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < musteriler.Length; i++)
            {
                if ((i+1) == indis) continue;
                Console.WriteLine("---{0}. Müsteri---", i + 1);
                Console.WriteLine(musteriler[i].MusteriAdi + " " + musteriler[i].MusteriSoyadi + "\n" +
                musteriler[i].Id + "\t" + musteriler[i].HesapTuru);
            }
            Console.WriteLine("Müşteri Bilgisi silinmiştir.");

        }
    }
}
