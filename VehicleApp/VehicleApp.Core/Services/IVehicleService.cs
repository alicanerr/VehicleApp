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
        public Task<CustomResponseDto<List<VehicleCatogoryDto>>> GetVehiclesCategories();
        public Task<List<VehicleCatogoryDto>> GetWebAllVehiclesCategory();
    }
}
