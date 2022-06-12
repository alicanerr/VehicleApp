using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core;
using VehicleApp.Core.Repositories;
using VehicleApp.Core.Services;
using VehicleApp.Core.UnitOfWorks;

namespace VehicleApp.Service.Services
{
    public class VehicleFeatureService:GenericService<VehicleFeatures>,IVehicleFeaturesService
    {
        private readonly IVehicleFeaturesRepository _vehicleFeaturesRepository;
        private readonly IMapper _mapper;

        public VehicleFeatureService(IGenericRepository<VehicleFeatures> repository, IVehicleFeaturesRepository vehicleFeaturesRepository, IMapper mapper, IGenericUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _vehicleFeaturesRepository=vehicleFeaturesRepository;
            _mapper = mapper;
        }
    }
}
