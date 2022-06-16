using System.Collections.Generic;
using VehicleAPI.Model.VehicleType;

namespace VecihleAPI.Data.VehicleData.CarData
{
    public interface ICarData
    {
        List<CarModel> GetCars();
        bool UpdateCars(List<CarModel> updatedCars);
    }
}