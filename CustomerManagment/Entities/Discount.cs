using GamerManagerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDemo.Entities
{
    public class Discount :IEntitiesManager
    {
        public int price { get; set; }
        public string DiscountMsg { get; set; }

        public int Id { get; set; }

        public void Add(IEntitiesManager entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(IEntitiesManager entities)
        {
            throw new NotImplementedException();
        }

        public void Updated(IEntitiesManager entities)
        {
            throw new NotImplementedException();
        }
    }
}
