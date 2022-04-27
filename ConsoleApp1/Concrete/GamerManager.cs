using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    internal class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + "adlı oyuncu eklenmiştir. ");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + "adlı oyuncu silinmiştir. ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + "adlı oyuncu güncellenmiştir. ");
        }
    }
}
