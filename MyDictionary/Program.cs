using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string> sehirler = new Dictionary<string>();
            sehirler.Add("Kastamonu");
            sehirler.Add("Çanakkale");
            sehirler.Add("Isparta");
            sehirler.Add("İstanbul");
            sehirler.Add("Düzce");

            Console.WriteLine(sehirler.Count);

        }
    }
}
