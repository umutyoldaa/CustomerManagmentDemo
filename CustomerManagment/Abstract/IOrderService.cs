using GamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDemo.Abstract
{
    public abstract class IOrderService
    {
        public void Sale(Discount discount, Gamer gamer)
        {
            Console.WriteLine($"{discount.DiscountMsg},{discount.price} Discount applied and  is sold to {gamer.FirstName}");
        }
    }
}
