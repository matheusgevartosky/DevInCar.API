using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevInCar.API.Migrations
{
    public partial class addUserSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "cr_4e9549f8-a131-43b9-9929-3707a160ab7b");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "cr_6abc0222-15fa-4dde-8c4e-376b07c7c207");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "cr_fd63fd17-715f-4d34-a8c8-3b3894a1bf6d");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "mt_6f94b6e1-428c-4a2a-945b-3138905663d3");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "mt_fe9fbd92-1b72-4816-92fc-8510a3ab2699");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "mt_ffa94f17-de67-4e00-9f59-b2e49e0c322b");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "tk_1ec9b454-41aa-4b73-be20-a34038f63133");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "tk_3018749b-b7e7-44f4-9230-761bc67d9c29");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "tk_a10ad5bd-0b99-4ff5-955b-7c1bcb9f8bdd");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EmailAddress", "Name", "Password" },
                values: new object[,]
                {
                    { "1", "yan@devinhouse.com", "Yan", "yan123" },
                    { "2", "admin@devinhouse.com", "Administrador", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BuyerId", "ChassisNumber", "Color", "DoorsNumber", "FuelType", "LoadingCapacity", "ManufacturingDate", "Name", "PlateNumber", "Potency", "SaleDate", "Status", "Value", "VehicleType", "WheelsNumber" },
                values: new object[,]
                {
                    { "cr_6ab4d679-e859-48d5-b45c-c22496d44b5d", null, "2b0246ca-c0ab-4b49-9d1a-80a47c836b11", "Preto", 4, 3, null, "01-01-2018", "Prisma", "XPT-1111", 180.0, "", true, 42000.0, 3, 4 },
                    { "cr_ea939f06-3e4a-4f4e-a993-cf4448124007", null, "c4fdb597-a901-4895-a1f9-dedb6653b48c", "Prata", 4, 3, null, "01-01-2013", "Punto", "XPT-0000", 130.0, "", true, 38000.0, 3, 4 },
                    { "cr_f2c559bd-bcc5-4d87-8b39-35c06efd7ff2", null, "0cf5a60c-bb8b-4278-b370-a7187dd766d9", "Branco", 4, 3, null, "01-01-2022", "Creta", "XPT-2222", 130.0, "", true, 150000.0, 3, 4 },
                    { "mt_223e1d0e-a875-4cc2-acba-dab628f8ca9f", null, "721d0393-6f3c-47ff-a427-e1448c2fff5e", "Vinho", null, 1, null, "01-01-1994", "750 Four", "TOP-0999", 750.0, "", true, 42000.0, 1, 2 },
                    { "mt_6c9a7aac-e106-40f9-8d3a-9e5e3aeb7ec6", null, "7b602007-5089-495d-8334-c01bffa2b7cf", "Branca", null, 1, null, "01-01-2020", "Fazer", "TOP-0777", 180.0, "", true, 13000.0, 1, 2 },
                    { "mt_6d2d9657-4070-4f88-82ed-ea15e676e36d", null, "d064a8a6-ab14-4866-9380-a75749b01f42", "Branca", null, 1, null, "01-01-2020", "CG Titan", "TOP-0666", 180.0, "", true, 13000.0, 1, 2 },
                    { "tk_286ff6a1-4fbf-4575-979c-1775850b6d74", null, "bb36f3b7-e364-425d-b212-77dbf8347e36", "Preto", 4, 2, 1000, "01-01-2018", "Hilux", "ABC-1234", 450.0, "", true, 80000.0, 4, 4 },
                    { "tk_4d32a3f7-fe49-4b91-9516-8f00ca6f1d77", null, "47130c42-db9c-4350-8d2a-08a500538f8c", "Preto", 4, 1, 2500, "01-01-2012", "Montana", "ABC-4341", 250.0, "", true, 35000.0, 4, 4 },
                    { "tk_f79cb0e4-398e-4be8-87ae-453e0ba1cedc", null, "bbdaf98f-d45b-452f-a565-5a44a368c039", "Preto", 4, 2, 2500, "01-01-2009", "F1000", "ABC-4323", 800.0, "", true, 70000.0, 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "cr_6ab4d679-e859-48d5-b45c-c22496d44b5d");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "cr_ea939f06-3e4a-4f4e-a993-cf4448124007");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "cr_f2c559bd-bcc5-4d87-8b39-35c06efd7ff2");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "mt_223e1d0e-a875-4cc2-acba-dab628f8ca9f");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "mt_6c9a7aac-e106-40f9-8d3a-9e5e3aeb7ec6");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "mt_6d2d9657-4070-4f88-82ed-ea15e676e36d");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "tk_286ff6a1-4fbf-4575-979c-1775850b6d74");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "tk_4d32a3f7-fe49-4b91-9516-8f00ca6f1d77");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: "tk_f79cb0e4-398e-4be8-87ae-453e0ba1cedc");

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
    }
}
