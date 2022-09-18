using GamerManagerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDemo.Entities
{
    public class Discount:IEntities
    {
        public int price { get; set; }
        public string DiscountMsg { get; set; }

        public int Id { get; set; }

    }
}
