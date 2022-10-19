using DevInCar.API.Models.Enum;

namespace DevInCar.API.Models
{
    public interface IVehicle
    {
        public string Id { get; set; }
        string? BuyerId { get; set; }
        string ChassisNumber { get; set; }
        string Color { get; set; }
        int? DoorsNumber { get; set; }
        FuelType FuelType { get; set; }
      
        int? LoadingCapacity { get; set; }
        string ManufacturingDate { get; set; }
        string Name { get; set; }
        string PlateNumber { get; set; }
        double Potency { get; set; }
        string SaleDate { get; set; }
        bool Status { get; set; }
        VehicleType VehicleType { get; set; }
        double Value { get; set; }
        int WheelsNumber { get; set; }
    }
}