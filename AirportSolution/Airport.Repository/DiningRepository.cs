using AnAirport.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnAirport.Repository
{
    public class Repository
    {
        AirportContext db = new AirportContext();

        public List<Dine> GetAll()
        {
            return db.Dines.ToList();
        }

        public Dine GetByID(int id)
        {
            return db.Dines.FirstOrDefault(t => t.ID == id);
        }

        public void Update(Dine dine)
        {
            db.Entry(dine).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Dine dine)
        {
            db.Entry(dine).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
