using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.DTOs;

namespace VehicleApp.Core.Services
{
    public interface ICategoryService:IGenericService<Category>
    {
        public Task<CustomResponseDto<CategoryVehicleDto>> GetCategoryIdVehiclesAsync(int categoryId);
    }
}
