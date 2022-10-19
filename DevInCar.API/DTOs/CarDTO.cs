using DevInCar.API.Models;
using DevInCar.API.Models.Enum;

namespace DevInCar.API.DTOs
{
    public class CarDTO
    {
       /* public AddCarDTO(string id, string? buyerId, Guid chassisNumber, string color, int? doorsNumber, FuelType fuelType, DateTime manufacturingDate, string name, string plateNumber, 
            double potency, bool status, VehicleType type, double value, int? loadingCapacity, double? saleValue, DateTime? saleDate) */
        
        public string color { get; set; }
        public int doorsNumber { get; set; }
        public CarFuelType fuelType { get; set; }
        public DateOnly ManufacturingDate { get; set; }
        public string name { get; set; }
        public string plateNumber { get; set; }
        public int potency { get; set; }
        public double value { get; set; }

        public static explicit operator Vehicle(CarDTO dto)
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
                LoadingCapacity = null,
                VehicleType = VehicleType.Carro,
                Id = $"cr_{ Guid.NewGuid()}",
                WheelsNumber = 4
            };
        }
    }
 }

