using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnAirport.Entities
{
    public class WorkPlace
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LocationDescription { get; set; }
        public virtual int TerminalID { get; set; }
        public virtual Terminal Terminal { get; set; }
    }
}
