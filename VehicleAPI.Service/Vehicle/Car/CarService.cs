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
            var lstCars = _carData.GetCars();
            var car = lstCars
                .FirstOrDefault(x => x.Id == id && !x.IsDelete);

            if (car == null)
            {
                throw new Exception("Car not found!");
            }

            car.IsDelete = true;
            return _carData.UpdateCars(lstCars);
        }

        public List<CarModel> GetVehicleColor(int color)
        {
            var lstCars = _carData.GetCars();
            return lstCars.Where(x => x.Color == (ColorEnum)color).ToList();
        }

        public bool TurnOnOffVehicleHeadlight(int id)
        {
            var lstCars = _carData.GetCars();
            var car = lstCars.FirstOrDefault(x => x.Id == id && !x.IsDelete);

            if (car == null)
            {
                throw new Exception("Car not found!");
            }

            car.IsHeadLightActive = car.IsHeadLightActive ? false : true;
            _carData.UpdateCars(lstCars);

            return car.IsHeadLightActive;
        }
    }
}
