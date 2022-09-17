using GamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDemo.Abstract
{
    interface IBaseGamerManager 
    {
        void Add(IEntitiesManager entities);
        void Remove(IEntitiesManager entities);
        void Updated(IEntitiesManager entities);
    }
}
