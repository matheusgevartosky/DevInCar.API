using DevInCar.API.Models;
using DevInCar.API.Models.Enum;

namespace DevInCar.API.Repositories
{
    public interface IVehicleRepository
    {
        bool AddVeiculo(Vehicle veiculo);
        string AlterarCor(Guid id, string Color);
        string ChangeValue(Guid id, double value);
        IEnumerable<IVehicle> GetVeiculos(VehicleType? type);
        IEnumerable<Vehicle> GetVeiculosDisponiveis(VehicleType? type);
        IEnumerable<Vehicle> GetVeiculosVendidos(VehicleType? type);
        Vehicle GetVendidosMaiorPreço(VehicleType? type);
        Vehicle GetVendidosMenorPreço(VehicleType? type);

        bool VenderVeiculo(Guid id, string buyerId, DateOnly date);
    }
}