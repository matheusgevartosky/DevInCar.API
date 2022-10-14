using DevInCar.API.DTOs;
using DevInCar.API.Models;
using DevInCar.API.Models.Enum;

namespace DevInCar.API.Services
{
    public interface IVehicleService
    {
        bool AddVehicle( CarDTO carDto);
        string ChangeColor(Guid id, string color);
        string ChangeValue(Guid id, double value);
        IEnumerable<IVehicle>? GetAvailableVehicles(VehicleType? type);
        IVehicle? GetSoldHigherPrice(VehicleType? type);
        IVehicle? GetSoldLowerPrice(VehicleType? type);
        IEnumerable<IVehicle> GetSoldVehicles(VehicleType? type);
        IEnumerable<IVehicle> GetVehicle(VehicleType? type);
        bool SellVehicle(Guid id, string buyerId, DateOnly date);
    }
}