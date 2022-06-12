using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Core
{
    public class VehicleProductionYears : BaseEntity
    {
        public string Year { get; set; }
        public int VehicleFeaturesId { get; set; }
        public VehicleFeatures VehicleFeatures { get; set; }
    }
}
