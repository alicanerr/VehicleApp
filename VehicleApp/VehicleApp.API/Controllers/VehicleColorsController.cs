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
    public class VehicleColorsController : CustomBaseController
    {
        private readonly IVehicleColorService _service;
        private readonly IMapper _mapper;

        public VehicleColorsController(IVehicleColorService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> ALl()
        {
            var vehiclecolor = await _service.GetAllAsync();
            var vehiclecolorDtos = _mapper.Map<List<VehicleColorsDto>>(vehiclecolor.ToList());
            return CreateActionResult(CustomResponseDto<List<VehicleColorsDto>>.Success(200, vehiclecolorDtos));
        }
        [HttpPost]
        public async Task<IActionResult> Save(VehicleColorsDto vehiclecolorsDto)
        {
            var vehiclecolor = await _service.AddAsync(_mapper.Map<VehicleColors>(vehiclecolorsDto));
            var vehiclecolorDtos = _mapper.Map<VehicleColorsDto>(vehiclecolor);
            return CreateActionResult(CustomResponseDto<VehicleColorsDto>.Success(201, vehiclecolorDtos));
        }
        [HttpPut]
        public async Task<IActionResult> Update(VehicleColorsDto vehiclecolorsDto)
        {
            await _service.UpdateAsync(_mapper.Map<VehicleColors>(vehiclecolorsDto));
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
