using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnAirport.Entities
{
    public class SleepingPod
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Terminal Terminal { get; set; }
        public virtual int? TerminalID { get; set; }
        public int HourlyRate { get; set; }
        public bool IsInUse { get; set; }
        public virtual ICollection<String> Perks { get; set; }

        public SleepingPod()
        {
            Perks = new List<String>();
        }
    }
}
