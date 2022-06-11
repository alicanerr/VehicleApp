using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core;

namespace VehicleApp.Repository.Seeds
{
    internal class VehicleSeed : IEntityTypeConfiguration<Vehicles>
    {
        public void Configure(EntityTypeBuilder<Vehicles> builder)
        {
            builder.HasData(new Vehicles { Id = 1, CategoryId=1, Model = "3.20" },
                new Vehicles { Id = 2, CategoryId = 1, Model = "Focus" },
                new Vehicles { Id = 3, CategoryId = 1, Model = "Corolla" },
                new Vehicles { Id = 4, CategoryId = 1, Model = "Astra" },
                new Vehicles { Id = 5, CategoryId = 1, Model = "Passat" },
                new Vehicles { Id = 6, CategoryId = 1, Model = "Spark" },
                new Vehicles { Id = 7, CategoryId = 1, Model = "Egea" }
                );
        }
    }
}
