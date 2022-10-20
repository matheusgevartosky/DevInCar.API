using DevInCar.API.Models;
using DevInCar.API.Models.Enum;
using System.Security.Cryptography.X509Certificates;

namespace DevInCar.API.DTOs
{
    public class TruckDTO
    {
        public string name { get; set; }
        public string plateNumber { get; set; }
        public string color { get; set; }
        public int doorsNumber { get; set; }
        public TruckFuelType fuelType { get; set; }
        public DateOnly ManufacturingDate { get; set; }
        public int potency { get; set; }
        public double value { get; set; }
        public int LoadingCapacity { get; set; }
         


        public static explicit operator Vehicle(TruckDTO dto)
        {
            return new Vehicle()
            {
                Name = dto.name,
                Color = dto.color,
                DoorsNumber = dto.doorsNumber,
                FuelType = (FuelType)dto.fuelType,
                ManufacturingDate = dto.ManufacturingDate.ToString(),
                PlateNumber = dto.plateNumber,
                Potency = dto.potency,
                Value = dto.value,
                ChassisNumber = $"{Guid.NewGuid()}",
                SaleDate = "",
                Status = true,
                BuyerId = null,
                LoadingCapacity = dto.LoadingCapacity,
                VehicleType = VehicleType.Caminhonete,
                Id = $"tk_{Guid.NewGuid()}",
                WheelsNumber = 4
            };
        }
    }
}
