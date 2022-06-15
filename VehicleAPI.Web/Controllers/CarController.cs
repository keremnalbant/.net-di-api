using Microsoft.AspNetCore.Mvc;
using VehicleAPI.Model.VehicleType;
using VehicleAPI.Service.Vehicle.Car;

namespace VehicleAPI.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            this._carService = carService;
        }

        [HttpDelete(Name = "DeleteVehicleById")]
        public bool DeleteVehicleById(int id)
        {
            return this._carService.DeleteVehicleById(id);
        }

        [HttpGet(Name = "GetVehicleColor")]
        public List<CarModel> GetVehicleColor(int color)
        {
            return this._carService.GetVehicleColor(color);
        }

        [HttpPost(Name = "TurnOnOffVehicleHeadlight")]
        public bool TurnOnOffVehicleHeadlight(int id)
        {
            return this._carService.TurnOnOffVehicleHeadlight(id);
        }
    }
}
