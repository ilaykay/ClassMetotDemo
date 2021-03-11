using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine(musteri.MusteriAdi+" "+ musteri.MusteriSoyadi+" "+musteri.Id);
        }
        public void MusteriListeleme(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
             Console.WriteLine(musteri.MusteriAdi+" "+musteri.MusteriSoyadi+" "+musteri.Id+"..."+"Müşteri eklenmiştir.");
                
            }
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi+" "+musteri.MusteriSoyadi+" "+"Kullanıncı Silinmiştir.");
        }
    }
}
