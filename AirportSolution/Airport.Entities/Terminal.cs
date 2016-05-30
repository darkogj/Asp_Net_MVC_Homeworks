using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnAirport.Entities
{
    public class Terminal
    {

        // An airport can have many terminal.
        // A terminal can have many shops, dines, workplaces, gates, sleeping pods.
        // One shop/dine can have multiple product names in it
        // One sleeping pod can have many perks (wifi, charging cable etc).

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
        public virtual ICollection<Dine> Dines { get; set; }
        public virtual ICollection<WorkPlace> Workplaces { get; set; }
        public virtual ICollection<Gate> Gates { get; set; }
        public virtual ICollection<SleepingPod> SleepingPods { get; set; }

        public Terminal()
        {
            Shops = new List<Shop>();
            Dines = new List<Dine>();
            Workplaces = new List<WorkPlace>();
            Gates = new List<Gate>();
            SleepingPods = new List<SleepingPod>();
        }
    }
}
