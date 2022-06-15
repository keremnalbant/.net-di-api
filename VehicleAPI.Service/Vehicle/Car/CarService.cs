using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VecihleAPI.Data.VehicleData.CarData;
using VehicleAPI.Model.Enum;
using VehicleAPI.Model.VehicleType;

namespace VehicleAPI.Service.Vehicle.Car
{
    public class CarService : ICarService
    {
        private ICarData _carData;  
        
        public CarService(ICarData carData)
        {
            this._carData = carData;
        }

        public bool DeleteVehicleById(int id)
        {
            return _carData.DeleteCarById(id);
        }

        public List<CarModel> GetVehicleColor(int color)
        {
            return _carData.GetVehiclesByColor(color);
        }

        public bool TurnOnOffVehicleHeadlight(int id)
        {
            return _carData.TurnOnOffVehicleHeadlight(id);
        }
    }
}
