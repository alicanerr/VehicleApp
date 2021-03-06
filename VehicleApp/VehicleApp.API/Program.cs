using VehicleApp.Repository.AppDbContexts;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VehicleApp.Core.UnitOfWorks;
using VehicleApp.Repository.UnitOfWorks;
using VehicleApp.Core.Repositories;
using VehicleApp.Repository.Repositories;
using VehicleApp.Core.Services;
using VehicleApp.Service.Services;
using VehicleApp.Service.Mappings;
using FluentValidation.AspNetCore;
using VehicleApp.Service.Validations;
using VehicleApp.API.Filters;
using Microsoft.AspNetCore.Mvc;
using VehicleApp.API.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers(options => options.Filters.Add(new ValideteFilterAttribute())).AddFluentValidation(x=> x.RegisterValidatorsFromAssemblyContaining<VehicleDtoValidator>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGenericUnitOfWork, UnitOfWorks>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddAutoMapper(typeof(MapProfiles));

builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddScoped<IVehicleService, VehicleService>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<IVehicleFeaturesRepository, VehicleFeaturesRepository>();
builder.Services.AddScoped<IVehicleFeaturesService, VehicleFeatureService>();

builder.Services.AddScoped<IVehicleColorsRepository, VehicleColorsRepository>();
builder.Services.AddScoped<IVehicleColorService, VehicleColorService>();


builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option => {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UserCustomException();

app.UseAuthorization();

app.MapControllers();

app.Run();
