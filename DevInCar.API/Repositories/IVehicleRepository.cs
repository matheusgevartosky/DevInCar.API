using DevInCar.API.Models;
using DevInCar.API.Models.Enum;

namespace DevInCar.API.Repositories
{
    public interface IVehicleRepository
    {
        IEnumerable<IVehicle> GetVeiculos(VehicleType type);
        IEnumerable<Vehicle> GetVeiculosDisponiveis();
        IEnumerable<Vehicle> GetVeiculosVendidos();
        IVehicle GetVendidosMaiorPreço();
        IVehicle GetVendidosMenorPreço();
        void AddVeiculo(Vehicle veiculo);
        void VenderVeiculo(int id, string idComprador, DateTime dataVenda);
        void AlterarCor(string Color);
        void ChangeValue(double value);

    }
}
