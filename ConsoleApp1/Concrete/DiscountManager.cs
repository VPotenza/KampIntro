using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    internal class DiscountManager : IDiscountService
    {
        public void Add(Discount discount)
        {
            Console.WriteLine(discount.Name + "adlı kampanya eklenmiştir");
        }

        public void Delete(Discount discount)
        {
            Console.WriteLine(discount.Name + "adlı kampanya silinmiştir");
        }

        public void Update(Discount discount)
        {
            Console.WriteLine(discount.Name + "adlı kampanya güncellenmiştir");
        }
    }
}
