using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VehicleApp.Core.Repositories;
using VehicleApp.Core.Services;
using VehicleApp.Core.UnitOfWorks;
using VehicleApp.Repository.AppDbContexts;
using VehicleApp.Repository.Repositories;
using VehicleApp.Repository.UnitOfWorks;
using VehicleApp.Service.Mappings;
using VehicleApp.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Services.AddAutoMapper(typeof(MapProfiles));


builder.Services.AddScoped<IGenericUnitOfWork, UnitOfWorks>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));


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
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
