using AnAirport.Entities;
using AnAirport.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnAirport.Repository
{
    public class AnAirportContextInitializer : DropCreateDatabaseAlways<AirportContext>
    {
        protected override void Seed(AirportContext context)
        {
            var terminalRepository = new TerminalRepository();
            var airport = new Airport { Name = "JK 1" };
            context.Airports.Add(airport);
            var terminal1 = new Terminal { Name = "P1" };
            var terminal2 = new Terminal { Name = "P2" };
            airport.Terminals.Add(terminal1);
            airport.Terminals.Add(terminal2);

            terminal1.Dines.Add(new Dine
            {
                Name = "Coffee bar",
                Category = DineCategory.Coffee,
                OpenHour = TimeSpan.FromHours(2),
                CloseHour = TimeSpan.FromHours(11),
                ProductNames = new List<String> { "Expresso", "Cappuccion", "Milkshake" }
            });

            terminal1.Shops.Add(new Shop
            {
                Name = "Shopping place",
                Category = ShopCategory.Various,
                OpenHour = TimeSpan.FromHours(0),
                CloseHour = TimeSpan.FromHours(23),
                Email = "shopping@shopping.com",
                ProductNames = new List<String> { "Water bottle", "iPad", "Tractor" }
            });

            terminal2.Shops.Add(new Shop
            {
                Name = "Shopping place",
                Category = ShopCategory.Various,
                OpenHour = TimeSpan.FromHours(0),
                CloseHour = TimeSpan.FromHours(23),
                Email = "shopping@shopping.com"
            });

            terminal2.Shops.Add(new Shop
            {
                Name = "Gift store",
                Category = ShopCategory.Gifts,
                OpenHour = TimeSpan.FromHours(5),
                CloseHour = TimeSpan.FromHours(15),
                Phone = "4343-43-4343"
            });

            terminal2.Shops.Add(new Shop
            {
                Name = "Duty-free cneter",
                Category = ShopCategory.DutyFree,
                OpenHour = TimeSpan.FromHours(0),
                CloseHour = TimeSpan.FromHours(0),
                Phone = "4343-43-4343"
            });

            terminal1.SleepingPods.Add(new SleepingPod
            {
                HourlyRate = 15,
                IsInUse = false,
                Name = "Sleeping pod",
                Perks = new List<string> { "Wi-fi", "bathroom", "charging cable" }
            });

            terminal1.Gates.Add(new Gate()
            {
                Name = "G1"
            });

            terminal2.Gates.Add(new Gate()
            {
                Name = "H1"
            });

            terminal1.Workplaces.Add(new WorkPlace()
            {
                LocationDescription = "Next to gate 1",
                Name = "Workplace Terminal 1"
            });

            terminal2.Workplaces.Add(new WorkPlace()
            {
                LocationDescription = "Next to gate 1",
                Name = "Workplace Terminal 2"
            });

            context.SaveChanges();
        }
    }
}
