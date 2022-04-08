using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Turan";
            musteri1.Yasi = 25;
            musteri1.Cins = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Oğuz";
            musteri2.Yasi = 21;
            musteri2.Cins = "Erkek";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ahmet";
            musteri3.Yasi = 28;
            musteri3.Cins = "Erkek";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Listele(musteri1, musteri2, musteri3);
        }
    }
}
