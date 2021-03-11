using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "ilayda";
            musteri1.MusteriSoyadi = "kaya";
            
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "irem";
            musteri2.MusteriSoyadi = "uysal";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "neriman";
            musteri3.MusteriSoyadi = "duru";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine("..........");
            musteriManager.MusteriListeleme(musteriler);
            Console.WriteLine("..........");
            musteriManager.MusteriSilme(musteri2);

        }
    }
}
