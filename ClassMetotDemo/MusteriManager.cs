using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad + " basarıyla eklendi.");
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad + " basarıyla silindi.");
        }
        public void MusteriListeleme(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler listeleniyor...");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Ad:" + musteri.Ad);
                Console.WriteLine("Soyad:" + musteri.Soyad);
                Console.WriteLine("TelNo:" + musteri.TelNo);
                Console.WriteLine("MusteriNo:" + musteri.MusteriNo);
                Console.WriteLine("*****************");

            }
        }
    }
}
