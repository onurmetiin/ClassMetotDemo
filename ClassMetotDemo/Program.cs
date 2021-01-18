using System;

namespace ClassMetotDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Hüseyin";
            musteri1.Soyad = "Metin";
            musteri1.DogumTarihi = 1966;
            musteri1.Sehir = "Alanya";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Mert";
            musteri2.Soyad = "Gülcan";
            musteri2.DogumTarihi = 1992;
            musteri2.Sehir = "Alanya";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2};

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);

            musteriManager.MusterileriListele(musteriler);

            musteriManager.MusteriSil(musteri2);
        }
    }
}
