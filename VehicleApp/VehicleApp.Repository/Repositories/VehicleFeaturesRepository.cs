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
    public class VehicleFeaturesRepository : GenericRepository<VehicleFeatures>, IVehicleFeaturesRepository
    {
        public VehicleFeaturesRepository(AppDbContext context) : base(context)
        {
        }
    }
}
