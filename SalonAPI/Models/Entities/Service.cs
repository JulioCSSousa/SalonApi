using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonAPI.Models.Entities
{
    public class Service
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
