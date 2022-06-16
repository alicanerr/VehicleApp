using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VehicleApp.Core.Services;

namespace VehicleApp.WEB.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;

        public VehiclesController(IVehicleService vehicleService, IMapper mapper)
        {
            _vehicleService = vehicleService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _vehicleService.GetWebAllVehiclesCategory());
        }
    }
}
