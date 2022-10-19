using DevInCar.API.DTOs;
using DevInCar.API.Models.Enum;
using DevInCar.API.Models;

namespace DevInCar.API.GraphQL.Subscriptions
{
    [ExtendObjectType(OperationTypeNames.Subscription)]
    public class SalesSubscription
    {
        [Subscribe]
        [GraphQLName("sold_vehicle")]
        public SubscriptionView SoldVehicle([EventMessage] SubscriptionView returnSubscription) => returnSubscription;

        [Subscribe]
        [GraphQLName("sold_vehicle(type!)")]
        public SubscriptionView SoldVehicleWithFilter([Topic] VehicleType vehicleType, [EventMessage] SubscriptionView returnSubscription) => returnSubscription;
    }
}
