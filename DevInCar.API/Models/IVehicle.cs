using DevInCar.API.Models.Enum;

namespace DevInCar.API.Models
{
    public interface IVehicle
    {
        string Id { get; set; }
        string? BuyerId { get; set; }
        Guid ChassisNumber { get; }
        string Color { get; set; }
        int DoorsNumber { get; }
        FuelType FuelType { get; }
        DateTime ManufacturingDate { get; }
        string Name { get; }
        string PlateNumber { get; }
        double Potency { get; }
        bool Status { get; set; }
        VehicleType Type { get; }
        double Value { get; set; }
        int LoadingCapacity { get; set; }
    }
}