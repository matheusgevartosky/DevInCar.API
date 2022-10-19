using DevInCar.API.Models;
using DevInCar.API.Models.Enum;
using Microsoft.JSInterop.Infrastructure;

namespace DevInCar.API.DTOs
{
    public class SubscriptionView : IVehicle
    {
        public SubscriptionView(Vehicle vehicle)
        {
            Id = vehicle.Id;
            BuyerId = vehicle.BuyerId;
            ChassisNumber = vehicle.ChassisNumber;
            Color = vehicle.Color;
            DoorsNumber = vehicle.DoorsNumber;
            FuelType = vehicle.FuelType;
            LoadingCapacity = vehicle.LoadingCapacity;
            ManufacturingDate = vehicle.ManufacturingDate;
            Name = vehicle.Name;
            PlateNumber = vehicle.PlateNumber;
            Potency = vehicle.Potency;
            SaleDate = vehicle.SaleDate;
            Status = vehicle.Status;
            VehicleType = vehicle.VehicleType;
            Value = vehicle.Value;
            WheelsNumber = vehicle.WheelsNumber;
        }

        public string Id { get; set; }
        public string? BuyerId { get; set ; }
        public string ChassisNumber { get; set; }
        public string Color { get ; set ; }
        public int? DoorsNumber { get; set; }
        public FuelType FuelType { get; set; }
        public int? LoadingCapacity { get; set; }
        public string ManufacturingDate { get; set; }
        public string Name { get; set; }
        public string PlateNumber { get; set; }
        public double Potency { get; set; }
        public string SaleDate { get; set; }
        public bool Status { get; set; }
        public VehicleType VehicleType { get; set; }
        public double Value { get; set; }
        public int WheelsNumber { get; set; }
        public Vehicle Vehicle { get; }

        /*public static explicit operator Vehicle(SubscriptionViewDTO dto)
         {
             return new Vehicle()
             {
                 Name = dto.Name,
                 Color = dto.Color,
                 DoorsNumber = dto.DoorsNumber,
                 FuelType = dto.FuelType,
                 ManufacturingDate = dto.ManufacturingDate,
                 PlateNumber = dto.PlateNumber,
                 Potency = dto.Potency,
                 Value = dto.Value,
                 ChassisNumber = dto.ChassisNumber,
                 SaleDate = dto.SaleDate,
                 Status = dto.Status,
                 BuyerId = dto.BuyerId,
                 LoadingCapacity = dto.LoadingCapacity,
                 VehicleType = dto.VehicleType,
                 Id = dto.Id,
                 WheelsNumber = dto.WheelsNumber,
             };
         }*/
    }
}
