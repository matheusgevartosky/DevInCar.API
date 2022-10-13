using DevInCar.API.Models;
using DevInCar.API.Models.Enum;

namespace DevInCar.API.Services
{
    public interface IVehicleService
    {
        string AddVehicle(VehicleType tipo, Vehicle veiculo);
        string ChangeColor(string id, string color);
        string ChangeValue(string id, string color);
        IEnumerable<IVehicle> GetAvailableVehicles(VehicleType? type);
        IVehicle GetSoldHigherPrice(VehicleType type);
        IVehicle GetSoldLowerPrice(VehicleType type);
        IEnumerable<IVehicle> GetSoldVehicles(VehicleType? type);
        IEnumerable<IVehicle> GetVehicle(VehicleType? type);
        string SellVehicle(string id, string buyerId, DateTime date);
    }
}