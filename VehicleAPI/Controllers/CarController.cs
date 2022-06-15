using Microsoft.AspNetCore.Mvc;
using VehicleAPI.Model.VehicleType;
using VehicleAPI.Service.Vehicle.Car;

namespace VehicleAPI.Controllers
{
    public class CarController : Controller
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            this._carService = carService;
        }

        public bool DeleteVehicleById(int id)
        {
            return this._carService.DeleteVehicleById(id);
        }

        public List<CarModel> GetVehicleColor(int color)
        {
            return this._carService.GetVehicleColor(color);
        }

        public bool TurnOnOffVehicleHeadlight(int id)
        {
            return this._carService.TurnOnOffVehicleHeadlight(id);
        }
    }
}
