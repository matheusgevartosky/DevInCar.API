using DevInCar.API.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace DevInCar.API.Models
{
    public class Vehicle : IVehicle
    {
        
        public Guid Id { get; set; }
        public string? BuyerId { get; set; }
        public string ChassisNumber { get; set; }
        public string Color { get; set; }
        public int? DoorsNumber { get; set; }
        public FuelType FuelType { get; set; }
        public int? LoadingCapacity { get; set; }
        public string ManufacturingDate { get; set; }
        public string Name { get; set; }
        public string PlateNumber { get; set; }
        public double Potency { get; set; }
        public string SaleDate { get; set; }
        public double? saleValue { get; set; }
        public bool Status { get; set; }
        public VehicleType VehicleType { get; set; }
        public double Value { get; set; }
    }
}