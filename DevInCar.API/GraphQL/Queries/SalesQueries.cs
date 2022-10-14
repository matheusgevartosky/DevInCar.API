using DevInCar.API.Models.Enum;
using DevInCar.API.Models;
using DevInCar.API.Services;

namespace DevInCar.API.GraphQL.Queries
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class SalesQueries
    {


        public IEnumerable<IVehicle> GetAvailableVehicles([Service] IVehicleService service, VehicleType? type)
        {
            return service.GetAvailableVehicles(type);
        }

        public IEnumerable<IVehicle> getSoldVehicles([Service] IVehicleService service, VehicleType? type)
        {
            return service.GetSoldVehicles(type);
        }

        public IVehicle? GetHigherPrice([Service] IVehicleService service, VehicleType? type)
        {
            return service.GetSoldHigherPrice(type);
        }

        public IVehicle? GetLowerPrice([Service]IVehicleService service, VehicleType? type)
        {
            return service.GetSoldLowerPrice(type);
        }



    }
}
