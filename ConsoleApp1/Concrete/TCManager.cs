using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    internal class TCManager
    {
        public void Kontrol(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " adlı oyuncu T.C. vatandaşıdır. ");
        }
    }
}
