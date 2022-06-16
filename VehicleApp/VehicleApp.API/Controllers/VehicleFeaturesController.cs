using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleApp.Core;
using VehicleApp.Core.DTOs;
using VehicleApp.Core.Services;

namespace VehicleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleFeaturesController : CustomBaseController
    {
        private readonly IVehicleFeaturesService _service;
        private readonly IMapper _mapper;

        public VehicleFeaturesController(IVehicleFeaturesService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> ALl()
        {
            var vehiclefeature = await _service.GetAllAsync();
            var vehiclefeatureDtos = _mapper.Map<List<VehicleFeaturesDto>>(vehiclefeature.ToList());
            return CreateActionResult(CustomResponseDto<List<VehicleFeaturesDto>>.Success(200, vehiclefeatureDtos));
        }
      
        [HttpPost]
        public async Task<IActionResult> Save(VehicleFeaturesDto vehicleFeaturesDto)
        {
            var vehiclefeature = await _service.AddAsync(_mapper.Map<VehicleFeatures>(vehicleFeaturesDto));
            var vehiclefeatureDtos = _mapper.Map<VehicleFeaturesDto>(vehiclefeature);
            return CreateActionResult(CustomResponseDto<VehicleFeaturesDto>.Success(201, vehiclefeatureDtos));
        }
        [HttpPut]
        public async Task<IActionResult> Update(VehicleFeaturesDto vehicleFeaturesDto)
        {
            await _service.UpdateAsync(_mapper.Map<VehicleFeatures>(vehicleFeaturesDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var vehiclefeature = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(vehiclefeature);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
