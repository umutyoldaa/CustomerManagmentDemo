using GamerManagerDemo.Abstract;
using GamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDemo.Concrete
{
    public class ProductManager : IBaseGamerManager
    {
        public void Add(IEntitiesManager entities)
        {
            Console.WriteLine(entities.Id+"ID product is added");
        }

        public void Remove(IEntitiesManager entities)
        {
            Console.WriteLine(entities.Id + " ID product is removed");
        }

        public void Updated(IEntitiesManager entities)
        {
            Console.WriteLine(entities.Id + "ID product is updated");
        }
    }
}
