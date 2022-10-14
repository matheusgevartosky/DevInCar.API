using DevInCar.API.Models;
using DevInCar.API.Models.Enum;
using DevInCar.API.Repositories;
using DevInCar.API.Services;

namespace DevInCar.API.GraphQL.Queries
{

    [ExtendObjectType(OperationTypeNames.Query)]
    public class VehicleQueries
    {
        public IEnumerable<IVehicle> GetVehicle([Service] IVehicleRepository repository,  VehicleType? type)
        {
            return repository.GetVeiculos(type);
        }

        public IEnumerable<IVehicle> GetVehicle([Service] IVehicleService service, VehicleType? type)
        {
            return service.GetVehicle(type);
        }


    }
}
