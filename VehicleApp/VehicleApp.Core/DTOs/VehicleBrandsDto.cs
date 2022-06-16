using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Core.DTOs
{
    public class VehicleBrandsDto : BaseDto
    {
        public string BrandsName { get; set; }
        public int VehicleFeaturesId { get; set; }
    }
}
