using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core;

namespace VehicleApp.Repository.AppDbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<VehicleBrands> VehicleBrands { get; set; }
        public DbSet<VehicleColors> VehicleColors { get; set; }
        public DbSet<VehicleFeatures> VehicleFeatures { get; set; }
        public DbSet<VehicleFuels> VehicleFuels { get; set; }
        public DbSet<VehicleProductionYears> VehicleProductionYears { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
