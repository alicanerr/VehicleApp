using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Core
{
    public class Vehicles : BaseEntity
    {
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public string Model { get; set; }
        public string ChassisNumber { get; set; }
        public string Explanation { get; set; }
        public string TechnicalWebUrl { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Stock { get; set; }
        public ICollection<VehicleFeatures> VehicleFeatures { get; set; }
    }
}
