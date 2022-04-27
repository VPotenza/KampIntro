using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine( game.Name + " adlı oyun eklendi. ");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun silindi. ");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun güncellendi. ");
        }
    }
}
