using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAPI.Model.Enum;
using VehicleAPI.Model.VehicleType;

namespace VehicleAPI.Service.Base
{
    public abstract class BaseService : IBaseService
    {
        public abstract List<CarModel> GetVehicleColor(int color);
        public abstract bool DeleteVehicleById(int id);
        public abstract bool TurnOnOffVehicleHeadlight(int id);
    }
}
