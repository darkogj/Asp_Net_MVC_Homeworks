using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnAirport.Entities
{
    public class Gate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Terminal Terminal { get; set; }
        public virtual int TerminalID { get; set; }
    }
}
