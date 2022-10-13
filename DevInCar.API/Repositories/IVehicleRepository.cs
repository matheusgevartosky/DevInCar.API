using DevInCar.API.Models;
using DevInCar.API.Models.Enum;

namespace DevInCar.API.Repositories
{
    public interface IVehicleRepository
    {
        string AddVeiculo(Vehicle veiculo);
        string AlterarCor(string id, string Color);
        string ChangeValue(string id, double value);
        IEnumerable<IVehicle> GetVeiculos(VehicleType? type);
        IEnumerable<Vehicle> GetVeiculosDisponiveis(VehicleType? type);
        IEnumerable<Vehicle> GetVeiculosVendidos(VehicleType? type);
        IVehicle GetVendidosMaiorPreço(VehicleType? type);
        IVehicle GetVendidosMenorPreço(VehicleType? type);
        string VenderVeiculo(string id, string idComprador, DateTime dataVenda);
    }
}