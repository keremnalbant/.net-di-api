using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAPI.Model.Enum;
using VehicleAPI.Model.VehicleType;

namespace VecihleAPI.Data.VehicleData.CarData
{
    public class CarData : ICarData
    {
        private static List<CarModel> lstCars = new List<CarModel>();

        public CarData()
        {
            if (lstCars.Count == 0)
            {
                FillCarList();
            }
        }

        private void FillCarList()
        {
            lstCars.Add(new CarModel() { Id = 1, Color = ColorEnum.White, IsDelete = false, IsHeadLightActive = true, Wheels = 4 });
            lstCars.Add(new CarModel() { Id = 2, Color = ColorEnum.Blue, IsDelete = false, IsHeadLightActive = true, Wheels = 4 });
            lstCars.Add(new CarModel() { Id = 3, Color = ColorEnum.Red, IsDelete = false, IsHeadLightActive = false, Wheels = 4 });
            lstCars.Add(new CarModel() { Id = 4, Color = ColorEnum.Black, IsDelete = false, IsHeadLightActive = false, Wheels = 4 });
            lstCars.Add(new CarModel() { Id = 5, Color = ColorEnum.White, IsDelete = false, IsHeadLightActive = true, Wheels = 4 });
            lstCars.Add(new CarModel() { Id = 6, Color = ColorEnum.Red, IsDelete = false, IsHeadLightActive = true, Wheels = 4 });
        }

        public List<CarModel> GetCars()
        {
            return lstCars;
        }

        public bool UpdateCars(List<CarModel> updatedCars)
        {
            lstCars = updatedCars;
            return true;
        }
    }
}
