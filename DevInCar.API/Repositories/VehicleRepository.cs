using DevInCar.API.Data.Context;
using DevInCar.API.Models;
using DevInCar.API.Models.Enum;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace DevInCar.API.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {

        private readonly IDbContextFactory<Context> _dbContextFactory;

        public VehicleRepository(IDbContextFactory<Context> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public string AddVeiculo(Vehicle veiculo)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Vehicles.Add(veiculo);
                context.SaveChanges();
            }
            return veiculo.Id;
        }

        public string AlterarCor(string id, string Color)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var veiculo = context.Vehicles.FirstOrDefault(x => x.Id == id);
                if (veiculo != null)
                {
                    veiculo.Color = Color;
                    context.SaveChanges();
                }
                return "Veiculo não cadastrado";
            }
        }

        public string ChangeValue(string id, double value)
        {

            using (var context = _dbContextFactory.CreateDbContext())
            {
                var veiculo = context.Vehicles.FirstOrDefault(x => x.Id == id);
                if (veiculo != null)
                {
                    veiculo.Value = value;
                    context.SaveChanges();
                    return "Valor atualizado";
                }
                return "Veiculo não cadastrado.";

            }
        }

        public IEnumerable<IVehicle> GetVeiculos(VehicleType? type)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                if (type != null)
                {
                    return context.Vehicles.Where(x => x.Type == type).ToList();
                }
                return context.Vehicles.ToList();
            }
        }

        public IEnumerable<Vehicle> GetVeiculosDisponiveis(VehicleType? type)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                if (type != null)
                {
                    var VeiculosDisponiveis = context
                        .Vehicles.Where(x => x.Type == type)
                        .Where(s => s.Status == true)
                        .ToList();
                    return VeiculosDisponiveis;
                }
                return context.Vehicles.Where(x => x.Status == true).ToList();
            }
        }

        public IEnumerable<Vehicle> GetVeiculosVendidos(VehicleType? type)
        {
            using (var dbContext = _dbContextFactory.CreateDbContext())
            {
                if (type != null)
                {
                    var VeiculosVendidos = dbContext
                        .Vehicles.Where(x => x.Type == type)
                        .Where(y => y.Status == false)
                        .ToList();
                    return VeiculosVendidos;
                }
                return dbContext.Vehicles.Where(x => x.Status == false).ToList();
            }
        }

        public IVehicle GetVendidosMaiorPreço(VehicleType? type)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                if (type != null)
                {
                    var veiculo = context
                        .Vehicles.Where(x => x.Type == type)
                        .Where(y => y.Status == false);
                    var maiorPreço = veiculo.OrderByDescending(x => x.saleValue).First();

                    return maiorPreço;
                }
                var veiculoSemTipo = context
                    .Vehicles.Where(x => x.Status == false);
                var maiorPreçoSemTipo = veiculoSemTipo.OrderByDescending(x => x.saleValue).First();
                return maiorPreçoSemTipo;
            }
        }

        public IVehicle GetVendidosMenorPreço(VehicleType? type)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                if (type != null)
                {
                    var veiculo = context
                        .Vehicles.Where(x => x.Equals(type))
                        .Where(y => y.Status == false);
                    var menorPreço = veiculo.OrderByDescending(x => x.saleValue).Last();
                    return menorPreço;
                }
                var veiculoSemTipo = context
                    .Vehicles.Where(x => x.Status == false);
                var menorPreçoSemTipo = veiculoSemTipo.OrderBy(x => x.saleValue).Last();
                return menorPreçoSemTipo;
            }
        }

        public string VenderVeiculo(string id, string idComprador, DateTime dataVenda)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var veiculo = context.Vehicles.FirstOrDefault(x => x.Id == id);
                if (veiculo != null)
                {
                    veiculo.BuyerId = idComprador;
                    veiculo.Status = false;
                    veiculo.SaleDate = DateTime.Now;
                    context.SaveChanges();
                }

                return "Veiculo não cadastrado ";
            }
        }
    }
}
