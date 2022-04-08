using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi" + musteri.Adi + " " + musteri.Yasi );
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi" + musteri.Adi + " " + musteri.Yasi);
        }

        public void Listele(params Musteri[] musteriler)
        {
            Console.WriteLine("Musteriler Listelendi.");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Yasi);
            }
        }

    }
}
