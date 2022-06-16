using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VehicleApp.Core.DTOs;
using VehicleApp.Core.Services;

namespace VehicleApp.WEB.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            
            var category = await _categoryService.GetAllAsync();
            var categoryDto = _mapper.Map<List<CategoryDto>>(category.ToList());
            return View(categoryDto);
        }
    }
}
