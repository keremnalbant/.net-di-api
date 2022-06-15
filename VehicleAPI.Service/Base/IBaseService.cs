using System.Collections.Generic;
using VehicleAPI.Model.Enum;
using VehicleAPI.Model.VehicleType;

namespace VehicleAPI.Service.Base
{
    public interface IBaseService
    {
        bool DeleteVehicleById(int id);
        List<CarModel> GetVehicleColor(int color);
        bool TurnOnOffVehicleHeadlight(int id);
    }
}