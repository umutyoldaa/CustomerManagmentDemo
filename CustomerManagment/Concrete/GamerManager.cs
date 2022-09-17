using GamerManagerDemo.Abstract;
using GamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDemo.Concrete
{
    public class GamerManager : IBaseGamerManager
    {
        public void Add(IEntitiesManager entities)
        {
            
            Console.WriteLine(entities.Id+" ID user is added");
        }

      

        public void Remove(IEntitiesManager entities)
        {
            Console.WriteLine(entities.Id + "ID user is removed");
        }

       
        public void Updated(IEntitiesManager entities)
        {
            Console.WriteLine(entities.Id + "ID user is updated");
        }
    }
}
