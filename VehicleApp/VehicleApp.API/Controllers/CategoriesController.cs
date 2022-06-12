using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleApp.Core.Services;

namespace VehicleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetCategoryIdVehicle (int categoryId)
        {
            return CreateActionResult(await _categoryService.GetCategoryIdVehiclesAsync(categoryId));
        }
    }
}
