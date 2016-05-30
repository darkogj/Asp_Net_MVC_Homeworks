using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnAirport.Entities
{
    public class Airport
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Terminal> Terminals { get; set; }

        public Airport()
        {
            Terminals = new List<Terminal>();
        }

    }
}
