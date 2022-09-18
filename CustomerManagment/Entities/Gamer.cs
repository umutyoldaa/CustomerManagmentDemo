using GamerManagerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDemo.Entities
{
    public class Gamer : IEntities
    {
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public int Id { get ; set ; }
    }
}
