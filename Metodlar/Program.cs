using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Adana Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Çilek";
            urun3.Fiyati = 8;
            urun3.Aciklama = "Dağ Çileği";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi + " " + urun.Fiyati + " " + urun.Aciklama);

            }


            Console.WriteLine("-------------Metotlar----------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil", 12);
            sepetManager.Ekle2("Elma", "Sarı", 12);
            sepetManager.Ekle2("Karpuz", "Adana", 12);




        }
    }
}
