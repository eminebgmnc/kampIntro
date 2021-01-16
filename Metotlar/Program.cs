using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("----------------METOTLAR-------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut",12 , "Yeşil Armut",10);
            sepetManager.Ekle2("Elma", 12, "Yeşil Elma",10);
            sepetManager.Ekle2("Karpuz", 12, "Diyarbakırın Karpuzu",10);
        }
    }
}
