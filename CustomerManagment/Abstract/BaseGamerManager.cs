using GamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDemo.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " added");
        }
        public virtual void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " updated");
        }
        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " deleted");
        }
    }
}
