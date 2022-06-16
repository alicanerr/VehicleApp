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
    internal class VehicleBrandsConfiguration : IEntityTypeConfiguration<VehicleBrands>
    {
        public void Configure(EntityTypeBuilder<VehicleBrands> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.VehicleFeatures).WithOne(x => x.VehicleBrands).HasForeignKey<VehicleBrands>(x => x.VehicleFeaturesId);

        }
    }
}
