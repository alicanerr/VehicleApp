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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetCategoryIdVehiclesAsync(int categoryid)
        {
            return await _context.Category.Include(x => x.Vehicles).Where(x => x.Id == categoryid).SingleOrDefaultAsync();
        }
    }
}
