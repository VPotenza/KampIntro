using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
            
        }
        public void Cıkar(int sayi1, int sayi2)
        {
            int cikar = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + cikar);

        }
        public void Carp(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " + carpim);

        }
        public void Bolme(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            Console.WriteLine("Sonuç : " + bolme);

        }
    }
}
