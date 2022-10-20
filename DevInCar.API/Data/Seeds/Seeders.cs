using DevInCar.API.Models;
using DevInCar.API.Models.Enum;

namespace DevInCar.API.Data.Seeds
{
    public class Seeders
    {
        public static List<Vehicle> VehiclesSeeder { get; set; } = new List<Vehicle>()
        {
            new Vehicle
            {
                Name = "Punto",
                Color = "Prata",
                DoorsNumber = 4,
                FuelType = FuelType.Flex,
                ManufacturingDate = "01-01-2013",
                PlateNumber = "XPT-0000",
                Potency = 130,
                Value = 38000.00,
                ChassisNumber = $"{Guid.NewGuid()}",
                SaleDate = "",
                Status = true,
                BuyerId = null,
                LoadingCapacity = null,
                VehicleType = VehicleType.Carro,
                Id = $"cr_{ Guid.NewGuid()}",
                WheelsNumber = 4
            },
            new Vehicle
            {
                Name = "Prisma",
                Color = "Preto",
                DoorsNumber = 4,
                FuelType = FuelType.Flex,
                ManufacturingDate = "01-01-2018",
                PlateNumber = "XPT-1111",
                Potency = 180,
                Value = 42000.00,
                ChassisNumber = $"{Guid.NewGuid()}",
                SaleDate = "",
                Status = true,
                BuyerId = null,
                LoadingCapacity = null,
                VehicleType = VehicleType.Carro,
                Id = $"cr_{ Guid.NewGuid()}",
                WheelsNumber = 4
            },
            new Vehicle
            {
                Name = "Creta",
                Color = "Branco",
                DoorsNumber = 4,
                FuelType = FuelType.Flex,
                ManufacturingDate = "01-01-2022",
                PlateNumber = "XPT-2222",
                Potency = 130,
                Value = 150000.00,
                ChassisNumber = $"{Guid.NewGuid()}",
                SaleDate = "",
                Status = true,
                BuyerId = null,
                LoadingCapacity = null,
                VehicleType = VehicleType.Carro,
                Id = $"cr_{ Guid.NewGuid()}",
                WheelsNumber = 4
            },
            new Vehicle
            {
                Name = "CG Titan",
                Color = "Branca",
                DoorsNumber = null,
                FuelType = FuelType.Gasolina,
                ManufacturingDate = "01-01-2020",
                PlateNumber = "TOP-0666",
                Potency = 180,
                Value = 13000.00,
                ChassisNumber = $"{Guid.NewGuid()}",
                SaleDate = "",
                Status = true,
                BuyerId = null,
                LoadingCapacity = null,
                VehicleType = VehicleType.Moto,
                Id = $"mt_{Guid.NewGuid()}",
                WheelsNumber = 2
            },

            new Vehicle
            {
                Name = "Fazer",
                Color = "Branca",
                DoorsNumber = null,
                FuelType = FuelType.Gasolina,
                ManufacturingDate = "01-01-2020",
                PlateNumber = "TOP-0777",
                Potency = 180,
                Value = 13000.00,
                ChassisNumber = $"{Guid.NewGuid()}",
                SaleDate = "",
                Status = true,
                BuyerId = null,
                LoadingCapacity = null,
                VehicleType = VehicleType.Moto,
                Id = $"mt_{Guid.NewGuid()}",
                WheelsNumber = 2
            },
            new Vehicle
            {
                Name = "750 Four",
                Color = "Vinho",
                DoorsNumber = null,
                FuelType = FuelType.Gasolina,
                ManufacturingDate = "01-01-1994",
                PlateNumber = "TOP-0999",
                Potency = 750,
                Value = 42000.00,
                ChassisNumber = $"{Guid.NewGuid()}",
                SaleDate = "",
                Status = true,
                BuyerId = null,
                LoadingCapacity = null,
                VehicleType = VehicleType.Moto,
                Id = $"mt_{Guid.NewGuid()}",
                WheelsNumber = 2
            },
            new Vehicle
            {
                Name = "Hilux",
                Color = "Preto",
                DoorsNumber = 4,
                FuelType = FuelType.Disel,
                ManufacturingDate = "01-01-2018",
                PlateNumber = "ABC-1234",
                Potency = 450,
                Value = 80000.00,
                ChassisNumber = $"{Guid.NewGuid()}",
                SaleDate = "",
                Status = true,
                BuyerId = null,
                LoadingCapacity = 1000,
                VehicleType = VehicleType.Caminhonete,
                Id = $"tk_{Guid.NewGuid()}",
                WheelsNumber = 4
            },
            new Vehicle
            {
                Name = "F1000",
                Color = "Preto",
                DoorsNumber = 4,
                FuelType = FuelType.Disel,
                ManufacturingDate = "01-01-2009",
                PlateNumber = "ABC-4323",
                Potency = 800,
                Value = 70000.00,
                ChassisNumber = $"{Guid.NewGuid()}",
                SaleDate = "",
                Status = true,
                BuyerId = null,
                LoadingCapacity = 2500,
                VehicleType = VehicleType.Caminhonete,
                Id = $"tk_{Guid.NewGuid()}",
                WheelsNumber = 4
            },
            new Vehicle
            {
                Name = "Montana",
                Color = "Preto",
                DoorsNumber = 4,
                FuelType = FuelType.Gasolina,
                ManufacturingDate = "01-01-2012",
                PlateNumber = "ABC-4341",
                Potency = 250,
                Value = 35000.00,
                ChassisNumber = $"{Guid.NewGuid()}",
                SaleDate = "",
                Status = true,
                BuyerId = null,
                LoadingCapacity = 2500,
                VehicleType = VehicleType.Caminhonete,
                Id = $"tk_{Guid.NewGuid()}",
                WheelsNumber = 4
            }
        };
    }
}
