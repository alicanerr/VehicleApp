using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Core.DTOs
{
    public class VehicleCatogoryDto : VehicleDto
    {
        public CategoryDto Category { get; set; }
    }
}
