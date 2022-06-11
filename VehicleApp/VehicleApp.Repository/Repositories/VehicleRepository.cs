using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core;
using VehicleApp.Core.Repositories;
using VehicleApp.Repository.AppDbContexts;

namespace VehicleApp.Repository.Repositories
{
    public class VehicleRepository : GenericRepository<Vehicles>, IVehicleRepository
    {
        public VehicleRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Vehicles>> GetVehiclesCategories()
        {
            return await _context.Vehicles.Include(x => x.Category).ToListAsync();
        }
    }
}
