using System;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler Urun1 = new Urunler();
            Urun1.UrunAdi = "Telefon";
            Urun1.UrunKodu = 1234;
            Urun1.UrunRengi = "Gri";
            Urun1.UrunFiyat = 5.500;

            Urunler Urun2 = new Urunler();
            Urun2.UrunAdi = "Laptop";
            Urun2.UrunKodu = 12345;
            Urun2.UrunRengi = "Siyah";
            Urun2.UrunFiyat = 8.500;

            Urunler Urun3 = new Urunler();
            Urun3.UrunAdi = "Fotoğraf Makinesi";
            Urun3.UrunKodu = 123456;
            Urun3.UrunRengi = "Siyah";
            Urun3.UrunFiyat = 3.500;

            Urunler[] urunler = new Urunler[] { Urun1, Urun2, Urun3 };
            Console.WriteLine("******For ile yazdırma işlemi**************");
            for (int i = 0; i < urunler.Length; i++)
            {
                
                Console.WriteLine("Ürün adı:" +urunler[i].UrunAdi+ " Ürün Kodu: " +urunler[i].UrunKodu+ " Ürün Fiyatı:" +urunler[i].UrunFiyat+ "Ürün Rnegi:"+urunler[i].UrunRengi);
            }
            Console.WriteLine("******Foreach ile yazdırma işlemi**************");
            foreach (var urun in urunler)
            {
                Console.WriteLine(" Ürün Adı:"+urun.UrunAdi+ " Ürün Kodu:" +urun.UrunKodu+ " Ürün Fiyatı " +urun.UrunFiyat+ " Ürün Rengi: " +urun.UrunRengi);
            }
            Console.WriteLine("While Döngüsü ile yazdırma");
            int sayac  = 0;
            while (sayac< urunler.Length)
            {
                Console.WriteLine("Ürün adı:" + urunler[sayac].UrunAdi + " Ürün Kodu: " + urunler[sayac].UrunKodu + " Ürün Fiyatı:" + urunler[sayac].UrunFiyat + "Ürün Rengi:" + urunler[sayac].UrunRengi);
                sayac++;
            }
           

        }
        class Urunler
        {
            public string UrunAdi{ get; set; }
            public int UrunKodu { get; set; }
            public double UrunFiyat { get; set; }
            public string UrunRengi { get; set; }
            

        }
    }
}
