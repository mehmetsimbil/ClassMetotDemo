using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.Id = 1;
            musteri1.Ad = "Mehmet";
            musteri1.Soyad = "Şimbil";

            musteri2.Id = 2;
            musteri2.Ad = "Eren";
            musteri2.Soyad = "Kınay";

            musteri3.Id = 3;
            musteri3.Ad = "Burak";
            musteri3.Soyad = "Kalınkaya";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Listele();
            Console.WriteLine("-------------");
            musteriManager.Sil(2);
            musteriManager.Listele();

        }
    }
}
