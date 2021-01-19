using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            {
                musteri1.MusteriAdi = "Emine";
                musteri1.MusteriSoyadi = "BAĞMANCI";
                musteri1.MusteriId = 1;
                musteri1.MusteriTc = 33333333333;
            }
            Musteri musteri2 = new Musteri();
            {
                musteri2.MusteriAdi = "Hatice";
                musteri2.MusteriSoyadi = "BAĞMANCI";
                musteri2.MusteriId = 2;
                musteri2.MusteriTc = 11111111111;
            }
            Musteri[] musteriler = new Musteri[] {musteri1,musteri2 };

            foreach (var musterilerim in musteriler)
            {
                Console.WriteLine(musterilerim.MusteriAdi+"  "+musterilerim.MusteriSoyadi+" "+musterilerim.MusteriTc);
                Console.WriteLine("*************************************");
            }

            

            MusteriManager musteriManager = new MusteriManager();
           


            musteriManager.Ekle("Muhammed", "Çiftçi", 3);

            musteriManager.Listeleme(musteriler);

            musteriManager.Silme(musteri1);
          
        }
    }
}
