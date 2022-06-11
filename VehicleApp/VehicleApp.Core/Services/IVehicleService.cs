using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.DTOs;

namespace VehicleApp.Core.Services
{
    public interface IVehicleService:IGenericService<Vehicles>
    {
        Task<CustomResponseDto<List<VehicleCatogoryDto>>> GetVehiclesCategories();
    }
}
