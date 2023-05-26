using net_Oponeo.Models;
using net_Oponeo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_Oponeo.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly DbTestContext _context;
        public WarehouseService(DbTestContext context)
        {
            _context = context;
        }
        public List<Tire> GetAllTires()
        {
            var Tires = _context.Tires.ToList();
            return Tires;
        }

        public void SaveTire(Tire tire)
        {
            _context.Tires.Add(tire);
            _context.SaveChanges();

        }

        public void SaveRim(Rim rim)
        {
            _context.Rims.Add(rim);
            _context.SaveChanges();
        }
        public List<Rim> GetAllRims()
        {
            var Rims = _context.Rims.ToList();
            return Rims;
        }
    }
}
