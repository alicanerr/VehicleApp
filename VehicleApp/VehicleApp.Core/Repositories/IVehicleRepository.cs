using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Core.Repositories
{
    public interface IVehicleRepository:IGenericRepository<Vehicles>
    {
        Task<List<Vehicles>> GetVehiclesCategories();
        Task<List<Vehicles>> GetWebAllVehiclesCategoryAsync();
    }
}
