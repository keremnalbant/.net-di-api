using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAPI.Model.Enum;

namespace VehicleAPI.Model.Base
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public ColorEnum Color { get; set; }   
        public bool IsDelete { get; set; }
    }
}
