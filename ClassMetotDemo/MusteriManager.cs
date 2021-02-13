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
        public void MusteriListeleme()
        {
            Console.WriteLine("Müşteriler listeleniyor...");
        }
    }
}
