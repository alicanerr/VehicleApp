using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core;
using VehicleApp.Core.DTOs;
using VehicleApp.Core.Repositories;
using VehicleApp.Core.Services;
using VehicleApp.Core.UnitOfWorks;

namespace VehicleApp.Service.Services
{
    public class VehicleService:GenericService<Vehicles>, IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public VehicleService(IGenericRepository<Vehicles> repository, IVehicleRepository vehicleRepository, IMapper mapper, IGenericUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<VehicleCatogoryDto>>> GetVehiclesCategories()
        {
            var vehicle = await _vehicleRepository.GetVehiclesCategories();
            var vehicleDtos = _mapper.Map<List<VehicleCatogoryDto>>(vehicle);
            return CustomResponseDto<List<VehicleCatogoryDto>>.Success(200, vehicleDtos);
        }
    }
}
