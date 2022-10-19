using DevInCar.API.DTOs;
using DevInCar.API.Models;
using DevInCar.API.Models.Enum;

namespace DevInCar.API.Services
{
    public interface IVehicleService
    {
        bool AddVehicle( Vehicle vehicle);
        string ChangeColor(string id, string color);
        string ChangeValue(string id, double value);
        IEnumerable<IVehicle>? GetAvailableVehicles(VehicleType? type);
        IVehicle? GetSoldHigherPrice(VehicleType? type);
        IVehicle? GetSoldLowerPrice(VehicleType? type);
        IEnumerable<IVehicle> GetSoldVehicles(VehicleType? type);
        IEnumerable<IVehicle> GetVehicle(VehicleType? type);
        Vehicle? SellVehicle(string id, string buyerId, DateOnly date);
    }
}