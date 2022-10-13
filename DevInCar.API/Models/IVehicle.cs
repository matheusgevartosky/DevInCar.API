using DevInCar.API.Models.Enum;

namespace DevInCar.API.Models
{
    public interface IVehicle
    {
        string? BuyerId { get; set; }
        Guid ChassisNumber { get; set; }
        string Color { get; set; }
        int? DoorsNumber { get; set; }
        FuelType FuelType { get; set; }
        string Id { get; set; }
        int? LoadingCapacity { get; set; }
        DateTime ManufacturingDate { get; set; }
        string Name { get; set; }
        string PlateNumber { get; set; }
        double Potency { get; set; }
        DateTime? SaleDate { get; set; }
        double? saleValue { get; set; }
        bool Status { get; set; }
        VehicleType Type { get; set; }
        double Value { get; set; }
    }
}