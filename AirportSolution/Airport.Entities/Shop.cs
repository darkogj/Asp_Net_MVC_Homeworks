using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnAirport.Entities
{
    public class Shop : Place
    {
        public ShopCategory Category { get; set; }
    }
}
