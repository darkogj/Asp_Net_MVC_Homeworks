using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnAirport.Entities
{
    public class Place
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public TimeSpan OpenHour { get; set; }
        public TimeSpan CloseHour { get; set; }
        public virtual ICollection<String> ProductNames { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public virtual Terminal Terminal { get; set; }
        public virtual int? TerminalID { get; set; }

        public Place()
        {
            ProductNames = new List<String>();
        }
    }
}
