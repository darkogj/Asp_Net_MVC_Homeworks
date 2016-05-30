using AnAirport.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnAirport.Repository
{
    public class AirportContext : DbContext 
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Dine> Dines { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<SleepingPod> SleepingPods { get; set; }
    }
}
