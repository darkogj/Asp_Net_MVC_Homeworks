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
    public class TerminalRepository
    {
        AirportContext db = new AirportContext();

        public List<Terminal> GetAll()
        {
            return db.Terminals.ToList();
        }

        public Terminal GetByID(int id)
        {
            return db.Terminals.FirstOrDefault(t => t.ID == id);
        }

        public void Add(Terminal terminal)
        {
            db.Terminals.Add(terminal);
            db.SaveChanges();
        }

        public void Update(Terminal terminal)
        {
            db.Entry(terminal).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Terminal terminal)
        {
            db.Entry(terminal).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
