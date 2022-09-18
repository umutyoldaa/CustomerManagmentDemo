using GamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDemo.Abstract
{
    public abstract class IDiscountManagerService 
    {
        public void Add(Discount discount)
        {
            Console.WriteLine($"Discount{discount.price} is added!");
        }

        public void Remove(Discount discount)
        {
            Console.WriteLine($"Discount{discount.price} is removed!");
        }

       

        public void Updated(Discount discount)
        {
            Console.WriteLine($"Discount{discount.price} is updated!");
        }

    }
}
