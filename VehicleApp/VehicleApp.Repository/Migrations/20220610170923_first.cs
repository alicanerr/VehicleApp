using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleApp.Repository.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ChassisNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalWebUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: true),
                    VehiclesId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleFeatures_Vehicles_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleFeaturesId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBrands_VehicleFeatures_VehicleFeaturesId",
                        column: x => x.VehicleFeaturesId,
                        principalTable: "VehicleFeatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VehicleFeaturesId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleColors_VehicleFeatures_VehicleFeaturesId",
                        column: x => x.VehicleFeaturesId,
                        principalTable: "VehicleFeatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleFuels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VehicleFeaturesId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFuels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleFuels_VehicleFeatures_VehicleFeaturesId",
                        column: x => x.VehicleFeaturesId,
                        principalTable: "VehicleFeatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleProductionYears",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    VehicleFeaturesId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleProductionYears", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleProductionYears_VehicleFeatures_VehicleFeaturesId",
                        column: x => x.VehicleFeaturesId,
                        principalTable: "VehicleFeatures",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Otomobil", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "SUV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "ELektrikli Araçlar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Panelvan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Motosikler", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Deniz Araçları", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Hava Araçları", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ActiveDateUpdate", "CategoryId", "ChassisNumber", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Model", "PurchasePrice", "SalePrice", "Stock", "TechnicalWebUrl", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "3.20", null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Focus", null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Corolla", null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Astra", null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Passat", null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Spark", null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Egea", null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBrands_VehicleFeaturesId",
                table: "VehicleBrands",
                column: "VehicleFeaturesId",
                unique: true,
                filter: "[VehicleFeaturesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleColors_VehicleFeaturesId",
                table: "VehicleColors",
                column: "VehicleFeaturesId",
                unique: true,
                filter: "[VehicleFeaturesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFeatures_VehiclesId",
                table: "VehicleFeatures",
                column: "VehiclesId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFuels_VehicleFeaturesId",
                table: "VehicleFuels",
                column: "VehicleFeaturesId",
                unique: true,
                filter: "[VehicleFeaturesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleProductionYears_VehicleFeaturesId",
                table: "VehicleProductionYears",
                column: "VehicleFeaturesId",
                unique: true,
                filter: "[VehicleFeaturesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CategoryId",
                table: "Vehicles",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleBrands");

            migrationBuilder.DropTable(
                name: "VehicleColors");

            migrationBuilder.DropTable(
                name: "VehicleFuels");

            migrationBuilder.DropTable(
                name: "VehicleProductionYears");

            migrationBuilder.DropTable(
                name: "VehicleFeatures");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
