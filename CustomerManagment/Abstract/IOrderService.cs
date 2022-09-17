using GamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDemo.Abstract
{
    interface IOrderService
    {
        void Sale(Discount discount,Gamer gamer);
    }
}
