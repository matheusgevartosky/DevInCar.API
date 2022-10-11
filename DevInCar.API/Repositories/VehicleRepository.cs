using DevInCar.API.Models;
using DevInCar.API.Models.Enum;

namespace DevInCar.API.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public void AddVeiculo(Vehicle veiculo)
        {
            
        }

        public void AlterarCor(string Color)
        {
            throw new NotImplementedException();
        }

        public void ChangeValue(double value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IVehicle> GetVeiculos(VehicleType type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> GetVeiculosDisponiveis()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> GetVeiculosVendidos()
        {
            throw new NotImplementedException();
        }

        public IVehicle GetVendidosMaiorPreço()
        {
            throw new NotImplementedException();
        }

        public IVehicle GetVendidosMenorPreço()
        {
            throw new NotImplementedException();
        }

        public void VenderVeiculo(int id, string idComprador, DateTime dataVenda)
        {
            throw new NotImplementedException();
        }
    }
}
