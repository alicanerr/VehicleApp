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
    internal class VehicleColorsConfiguration : IEntityTypeConfiguration<VehicleColors>
    {
        public void Configure(EntityTypeBuilder<VehicleColors> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ColorsName).IsRequired().HasMaxLength(100);
            builder.HasOne(x => x.VehicleFeatures).WithOne(x => x.VehicleColors).HasForeignKey<VehicleColors>(x => x.VehicleFeaturesId);

        }
    }
}
