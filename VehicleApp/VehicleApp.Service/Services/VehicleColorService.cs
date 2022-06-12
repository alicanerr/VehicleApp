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
    public class VehicleColorService:GenericService<VehicleColors>,IVehicleColorService
    {
        private readonly IVehicleColorsRepository _vehicleColorsRepository;
        private readonly IMapper _mapper;

        public VehicleColorService(IGenericRepository<VehicleColors> repository, IVehicleColorsRepository vehicleColorsRepository, IMapper mapper, IGenericUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _vehicleColorsRepository = vehicleColorsRepository;
            _mapper = mapper;
        }
    }
}
