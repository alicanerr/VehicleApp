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
    public class VehiclesController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IVehicleService _service;

        public VehiclesController(IMapper mapper, IVehicleService service )
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetVehicleCategories()
        {
            return CreateActionResult(await _service.GetVehiclesCategories());
        }

        [HttpGet]
        public async Task<IActionResult> ALl()
        {
            var vehicle = await _service.GetAllAsync();
            var vehicleDtos = _mapper.Map<List<VehicleDto>>(vehicle.ToList());
            return CreateActionResult(CustomResponseDto<List<VehicleDto>>.Success(200, vehicleDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var vehicle = await _service.GetByIdAsync(id);
            var vehicleDtos = _mapper.Map<VehicleDto>(vehicle);
            return CreateActionResult(CustomResponseDto<VehicleDto>.Success(200, vehicleDtos));
        }
        [HttpPost]
        public async Task<IActionResult> Save(VehicleDto vehicleDto)
        {
            var vehicle = await _service.AddAsync(_mapper.Map<Vehicles>(vehicleDto));
            var vehicleDtos = _mapper.Map<VehicleDto>(vehicle);
            return CreateActionResult(CustomResponseDto<VehicleDto>.Success(201, vehicleDtos));
        }
        [HttpPut]
        public async Task<IActionResult> Update(VehicleDto vehicleDto)
        {
            await _service.UpdateAsync(_mapper.Map<Vehicles>(vehicleDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var vehicle = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(vehicle);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
