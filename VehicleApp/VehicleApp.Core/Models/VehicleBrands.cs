﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Core
{
    public class VehicleBrands :BaseEntity
    {
        public string? BrandsName { get; set; }
        public string? ShortCode { get; set; }
        public string? Explanation { get; set; }
        public int? VehicleFeaturesId { get; set; }
        public VehicleFeatures VehicleFeatures { get; set; }

    }
}
