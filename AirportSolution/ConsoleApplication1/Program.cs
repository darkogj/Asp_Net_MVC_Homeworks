using AnAirport.Entities;
using AnAirport.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<AirportContext>(new AnAirportContextInitializer());
            var context = new AirportContext();
            context.Airports.Add(new Airport { Name = "Test 1" });
        }
    }
}
