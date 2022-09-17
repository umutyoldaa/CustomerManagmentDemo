using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerManagerDemo.Abstract;
using GamerManagerDemo.Entities;

namespace GamerManagerDemo.Concrete
{
    class OrderManager:IOrderService
    {
      

        public void Sale(Discount discount, Gamer gamer)
        {
            Console.WriteLine($"{discount.Id} ID number Discount applied and  is sold to {gamer.FirstName}");
        }
    }
}
