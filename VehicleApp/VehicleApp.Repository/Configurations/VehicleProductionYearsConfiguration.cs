using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core;

namespace VehicleApp.Repository.Configurations
{
    internal class VehicleProductionYearsConfiguration : IEntityTypeConfiguration<VehicleProductionYears>
    {
        public void Configure(EntityTypeBuilder<VehicleProductionYears> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Year).IsRequired().HasMaxLength(4);
            builder.HasOne(x => x.VehicleFeatures).WithOne(x=> x.VehicleProductionYears).HasForeignKey<VehicleProductionYears>(x => x.VehicleFeaturesId);

        }
    }
}
