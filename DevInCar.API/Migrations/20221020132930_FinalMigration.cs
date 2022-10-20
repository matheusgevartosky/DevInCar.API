using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevInCar.API.Migrations
{
    public partial class FinalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BuyerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChassisNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoorsNumber = table.Column<int>(type: "int", nullable: true),
                    FuelType = table.Column<int>(type: "int", nullable: false),
                    LoadingCapacity = table.Column<int>(type: "int", nullable: true),
                    ManufacturingDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PlateNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Potency = table.Column<double>(type: "float", nullable: false),
                    SaleDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    VehicleType = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    WheelsNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BuyerId", "ChassisNumber", "Color", "DoorsNumber", "FuelType", "LoadingCapacity", "ManufacturingDate", "Name", "PlateNumber", "Potency", "SaleDate", "Status", "Value", "VehicleType", "WheelsNumber" },
                values: new object[,]
                {
                    { "cr_4e9549f8-a131-43b9-9929-3707a160ab7b", null, "6ebfb808-3f8e-4f24-a1f8-2baaab7e71db", "Preto", 4, 3, null, "01-01-2018", "Prisma", "XPT-1111", 180.0, "", true, 42000.0, 3, 4 },
                    { "cr_6abc0222-15fa-4dde-8c4e-376b07c7c207", null, "e7170357-f505-453b-bca6-2d6f0044a372", "Prata", 4, 3, null, "01-01-2013", "Punto", "XPT-0000", 130.0, "", true, 38000.0, 3, 4 },
                    { "cr_fd63fd17-715f-4d34-a8c8-3b3894a1bf6d", null, "c2b18dd3-16dc-47fb-a9f1-2263e4bce272", "Branco", 4, 3, null, "01-01-2022", "Creta", "XPT-2222", 130.0, "", true, 150000.0, 3, 4 },
                    { "mt_6f94b6e1-428c-4a2a-945b-3138905663d3", null, "688ed208-c289-4d7a-988d-2b95f024a51d", "Vinho", null, 1, null, "01-01-1994", "750 Four", "TOP-0999", 750.0, "", true, 42000.0, 1, 2 },
                    { "mt_fe9fbd92-1b72-4816-92fc-8510a3ab2699", null, "97f27931-c34e-43e2-b4d5-25fdaa7fa354", "Branca", null, 1, null, "01-01-2020", "Fazer", "TOP-0777", 180.0, "", true, 13000.0, 1, 2 },
                    { "mt_ffa94f17-de67-4e00-9f59-b2e49e0c322b", null, "d9251edf-fc7a-41c9-b7c7-f585d90bb1c1", "Branca", null, 1, null, "01-01-2020", "CG Titan", "TOP-0666", 180.0, "", true, 13000.0, 1, 2 },
                    { "tk_1ec9b454-41aa-4b73-be20-a34038f63133", null, "2e0d419d-4929-4d25-b090-67284e1cc955", "Preto", 4, 1, 2500, "01-01-2012", "Montana", "ABC-4341", 250.0, "", true, 35000.0, 4, 4 },
                    { "tk_3018749b-b7e7-44f4-9230-761bc67d9c29", null, "9d759744-dab0-45d1-8be3-a0f4612907f1", "Preto", 4, 2, 2500, "01-01-2009", "F1000", "ABC-4323", 800.0, "", true, 70000.0, 4, 4 },
                    { "tk_a10ad5bd-0b99-4ff5-955b-7c1bcb9f8bdd", null, "ee211485-bb5c-4d07-945b-a769d2f7e974", "Preto", 4, 2, 1000, "01-01-2018", "Hilux", "ABC-1234", 450.0, "", true, 80000.0, 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
