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
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, ICategoryRepository categoryRepository, IMapper mapper, IGenericUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
    }

        public async Task<CustomResponseDto<CategoryVehicleDto>> GetCategoryIdVehiclesAsync(int categoryId)
        {
            var category = await _categoryRepository.GetCategoryIdVehiclesAsync(categoryId);
            var categoryDto = _mapper.Map<CategoryVehicleDto>(category);
            return CustomResponseDto<CategoryVehicleDto>.Success(200, categoryDto);
        }
    }
}
