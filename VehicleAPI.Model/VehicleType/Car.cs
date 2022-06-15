using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAPI.Model.Base;

namespace VehicleAPI.Model.VehicleType
{
    public class CarModel : VehicleModel
    {
        public bool IsHeadLightActive { get; set; }
        public int Wheels { get; set; }
    }
}
