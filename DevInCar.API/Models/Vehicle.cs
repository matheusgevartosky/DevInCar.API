using DevInCar.API.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace DevInCar.API.Models
{
    public class Vehicle : IVehicle
    {
        public Vehicle(string id, string? buyerId, Guid chassisNumber, string color, int? doorsNumber, FuelType fuelType, DateTime manufacturingDate, string name, string plateNumber, double potency, bool status, VehicleType type, double value, int? loadingCapacity, double? saleValue, DateTime? saleDate)
        {
            Id = id;
            BuyerId = buyerId;
            ChassisNumber = chassisNumber;
            Color = color;
            DoorsNumber = doorsNumber;
            FuelType = fuelType;
            ManufacturingDate = manufacturingDate;
            Name = name;
            PlateNumber = plateNumber;
            Potency = potency;
            Status = status;
            Type = type;
            Value = value;
            LoadingCapacity = loadingCapacity;
            this.saleValue = saleValue;
            SaleDate = saleDate;
        }

        [Key]
        public string Id { get; set; }
        public string? BuyerId { get; set; }
        public Guid ChassisNumber { get; set; }
        public string Color { get; set; }
        public int? DoorsNumber { get; set; }
        public FuelType FuelType { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public string Name { get; set; }
        public string PlateNumber { get; set; }
        public double Potency { get; set; }
        public bool Status { get; set; }
        public VehicleType Type { get; set; }
        public double Value { get; set; }
        public int? LoadingCapacity { get; set; } 
        public double? saleValue { get; set; } 
        public DateTime? SaleDate { get; set; }

    }
}
