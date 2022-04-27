using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Abstract;

namespace ConsoleApp1.Concrete
{
    internal class SaleManager : ISaleService
    {
        public void Iade(Gamer gamer, Discount discount, Game game)
        {
            Console.WriteLine(gamer.Name + " adlı oyuncu " + discount.Name + " indirimi kapsamında aldığı " + game.Name + " adlı oyunu iade etmiştir.");
        }

        public void Sale(Gamer gamer, Discount discount, Game game)
        {
            Console.WriteLine(gamer.Name + " adlı oyuncu " + discount.Name + " indirimi kapsamında aldığı " + game.Name + " adlı oyunu satın almıştır.");
        }
    }
}
