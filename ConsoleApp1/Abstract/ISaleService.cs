using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstract
{
    internal interface ISaleService
    {
        void Sale(Gamer gamer, Discount discount, Game game);
        void Iade(Gamer gamer, Discount discount, Game game);
    }
}
