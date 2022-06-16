using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Core.DTOs
{
    public class CategoryVehicleDto:CategoryDto
    {
        public List<VehicleDto> Vehicles { get; set; }
    }
}
