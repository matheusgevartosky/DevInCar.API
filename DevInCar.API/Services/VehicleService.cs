using DevInCar.API.DTOs;
using DevInCar.API.Models;
using DevInCar.API.Models.Enum;
using DevInCar.API.Repositories;

namespace DevInCar.API.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public bool AddVehicle(Vehicle vehicle)
        {
            
            return _vehicleRepository.AddVeiculo(vehicle);
        }

        public string ChangeColor(string id, string color)
        {
            return _vehicleRepository.AlterarCor(id, color);
        }

        public string ChangeValue(string id, double value)
        {
            return _vehicleRepository.ChangeValue(id, value);
        }

        public IEnumerable<IVehicle> GetVehicle(VehicleType? type)
        {
            return _vehicleRepository.GetVeiculos(type);
        }

        public IEnumerable<IVehicle> GetAvailableVehicles(VehicleType? type)
        {
            return _vehicleRepository.GetVeiculosDisponiveis(type);
        }

        public IEnumerable<IVehicle> GetSoldVehicles(VehicleType? type)
        {
            return _vehicleRepository.GetVeiculosVendidos(type);
        }

        public IVehicle? GetSoldHigherPrice(VehicleType? type)
        {
            return _vehicleRepository.GetVendidosMaiorPreço(type);
        }

        public IVehicle? GetSoldLowerPrice(VehicleType? type)
        {
            return _vehicleRepository.GetVendidosMenorPreço(type);
        }

        public Vehicle SellVehicle(string id, string buyerId, DateOnly date)
        {
            return _vehicleRepository.VenderVeiculo(id, buyerId, date);
        }


    }
}
