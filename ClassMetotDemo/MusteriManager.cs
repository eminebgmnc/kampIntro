using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        public void Ekle(string MusteriAdi, string MusteriSoyadi, int MusteriId)

        {
            Console.WriteLine("Bir Müşteri Kaydı daha eklendi Adı:" + MusteriAdi);
        }


        public void Listeleme(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listeniz Aşağıdaki gibidir");
            foreach (var musteri in musteriler)
            {
               
                Console.WriteLine(musteri.MusteriAdi+" "
                    +musteri.MusteriSoyadi+" "
                    +musteri.MusteriTc);
            }
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId+ " " +"numaralı müşteri müşteri listesinden silinmiştir");
        }
        
    }
}
