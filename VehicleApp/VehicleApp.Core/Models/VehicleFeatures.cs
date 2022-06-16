using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Core
{
    public class VehicleFeatures : BaseEntity
    {
        public int? VehicleId { get; set; }
        public VehicleBrands VehicleBrands { get; set; }
        public VehicleColors VehicleColors { get; set; }
        public VehicleFuels VehicleFuels { get; set; }
        public Vehicles Vehicles { get; set; }
        public VehicleProductionYears VehicleProductionYears { get; set; }

    }
}
