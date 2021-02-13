using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Mehmet ";
            musteri1.Soyad = "Yıldırım";
            musteri1.TelNo =5365671234;
            musteri1.MusteriNo = 01;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Mert ";
            musteri2.Soyad = "Günes";
            musteri2.TelNo =5361234567;
            musteri2.MusteriNo = 02;

            

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            
            musteriManager.MusteriEkleme(musteri2);
            
            musteriManager.MusteriSilme(musteri1);
            
            musteriManager.MusteriSilme(musteri2);
            


            musteriManager.MusteriListeleme();
            
            Console.WriteLine("*************");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
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
