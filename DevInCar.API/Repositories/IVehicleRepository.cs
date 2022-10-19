using DevInCar.API.Models;
using DevInCar.API.Models.Enum;

namespace DevInCar.API.Repositories
{
    public interface IVehicleRepository
    {
        bool AddVeiculo(Vehicle veiculo);
        string AlterarCor(string id, string Color);
        string ChangeValue(string id, double value);
        IEnumerable<IVehicle> GetVeiculos(VehicleType? type);
        IEnumerable<Vehicle> GetVeiculosDisponiveis(VehicleType? type);
        IEnumerable<Vehicle> GetVeiculosVendidos(VehicleType? type);
        Vehicle GetVendidosMaiorPreço(VehicleType? type);
        Vehicle GetVendidosMenorPreço(VehicleType? type);

        Vehicle VenderVeiculo(string id, string buyerId, DateOnly date);
    }
}