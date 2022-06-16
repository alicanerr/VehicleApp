using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Core.DTOs
{
    public class VehicleDto:BaseDto
    {
        public int CategoryId { get; set; }
        public string Model { get; set; }
        public string ChassisNumber { get; set; }
        public string Explanation { get; set; }
        public string TechnicalWebUrl { get; set; }
        public decimal SalePrice { get; set; }
    }
}
