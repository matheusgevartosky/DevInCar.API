using DevInCar.API.DTOs;
using DevInCar.API.Models;
using DevInCar.API.Models.Enum;

namespace DevInCar.API.GraphQL.Subscriptions
{
    [ExtendObjectType(OperationTypeNames.Subscription)]
    public class VehiclesSubscription
    {
        [Subscribe]
        [GraphQLName("Registered_vehicle")]
        public Vehicle addedVehicle([EventMessage] Vehicle vehicle) => vehicle;

        [Subscribe]
        [GraphQLName("Registered_vehicle(type!)")]
        public SubscriptionView addedVehicleWithFilter([Topic]VehicleType vehicleType, [EventMessage] SubscriptionView returnSubscription) => returnSubscription;
    }
}
