using net_Oponeo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_Oponeo.Services.Interfaces
{
    public interface IWarehouseService
    {
        void SaveTire(Tire tire);
        List<Tire> GetAllTires();
        void SaveRim(Rim rim);
        List<Rim> GetAllRims();
    }
}
