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
    internal class VehicleFuelsConfiguration:IEntityTypeConfiguration<VehicleFuels>
    {
        public void Configure(EntityTypeBuilder<VehicleFuels> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.FuelsName).IsRequired().HasMaxLength(100);
            builder.HasOne(x => x.VehicleFeatures).WithOne(x => x.VehicleFuels).HasForeignKey<VehicleFuels>(x => x.VehicleFeaturesId);

        }
    }
}
