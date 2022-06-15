using System.Collections.Generic;
using VehicleAPI.Model.VehicleType;

namespace VecihleAPI.Data.VehicleData.CarData
{
    public interface ICarData
    {
        List<CarModel> GetVehiclesByColor(int color);
        bool TurnOnOffVehicleHeadlight(int id);
        bool DeleteCarById(int id);
    }
}