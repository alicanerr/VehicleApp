using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.DTOs;
using FluentValidation;

namespace VehicleApp.Service.Validations
{
    public class VehicleDtoValidator:AbstractValidator<VehicleDto>
    {
        public VehicleDtoValidator()
        {
            RuleFor(x => x.Model).NotEmpty().WithMessage("{PropertyName} girilmesi gerekli !!!");
            RuleFor(x => x.SalePrice).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName}'in 0dan büyük olması gerekli !!!");
            RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} Kategori Id 0 olamaz");
        }
    }
}
