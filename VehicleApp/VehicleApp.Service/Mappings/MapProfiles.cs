using AutoMapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core;
using VehicleApp.Core.DTOs;

namespace VehicleApp.Service.Mappings
{
    public class MapProfiles:Profile
    {
        public MapProfiles()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<VehicleBrands, VehicleBrandsDto>().ReverseMap();
            CreateMap<VehicleColors, VehicleColorsDto>().ReverseMap();
            CreateMap<VehicleFeatures, VehicleFeaturesDto>().ReverseMap();
            CreateMap<VehicleFuels, VehicleFuelsDto>().ReverseMap();
            CreateMap<VehicleProductionYears, VehicleProductionYearsDto>().ReverseMap();
            CreateMap<Vehicles, VehicleDto>().ReverseMap();
            CreateMap<Vehicles, VehicleCatogoryDto>();
            CreateMap<Category, CategoryVehicleDto>();
        }
    }
}
