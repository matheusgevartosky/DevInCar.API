using DevInCar.API.Models.Enum;
using DevInCar.API.Models;
using DevInCar.API.Services;

namespace DevInCar.API.GraphQL.Queries
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class SalesQueries
    {

        [GraphQLName("get_avaliable_vehicle(type?)")]
        public IEnumerable<IVehicle> GetAvailableVehicles([Service] IVehicleService service, VehicleType? type)
        {
            return service.GetAvailableVehicles(type);
        }
        [GraphQLName("get_sold_vehicle(type?)")]
        public IEnumerable<IVehicle> getSoldVehicles([Service] IVehicleService service, VehicleType? type)
        {
            return service.GetSoldVehicles(type);
        }
        [GraphQLName("get_higher_price(type?)")]
        public IVehicle? GetHigherPrice([Service] IVehicleService service, VehicleType? type)
        {
            return service.GetSoldHigherPrice(type);
        }
        [GraphQLName("get_lower_price(type?)")]
        public IVehicle? GetLowerPrice([Service]IVehicleService service, VehicleType? type)
        {
            return service.GetSoldLowerPrice(type);
        }
        [GraphQLName("get_user(id?)")]
        public IEnumerable<User?> GetUser([Service] IUserService service, string? id)
        {
            return service.GetUser(id);
        }



    }
}
