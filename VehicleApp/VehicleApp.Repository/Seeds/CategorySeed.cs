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
    internal class CategorySeed :IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category { Id=1, Name ="Otomobil"},
                new Category { Id=2,Name="SUV"},
                new Category { Id=3,Name="ELektrikli Araçlar"},
                new Category { Id=4,Name= "Panelvan"},
                new Category { Id=5,Name= "Motosikler"},
                new Category { Id=6,Name="Deniz Araçları"},
                new Category { Id=7, Name="Hava Araçları"}
                );
        }
    }
}
