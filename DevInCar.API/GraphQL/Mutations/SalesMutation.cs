using DevInCar.API.DTOs;
using DevInCar.API.GraphQL.Subscriptions;
using DevInCar.API.Models;
using DevInCar.API.Services;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Subscriptions;

namespace DevInCar.API.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class SalesMutation
    {
        [Authorize]
        public async Task<Vehicle?> SellVehicle([Service] IVehicleService service, string id, string idComprador, DateOnly date ,[Service] ITopicEventSender eventSender)
        {
            var vehicle =  service.SellVehicle(id, idComprador, date);
            var returnSubscription = new SubscriptionView(vehicle);
            await eventSender.SendAsync(vehicle.VehicleType, returnSubscription);
            await eventSender.SendAsync(nameof(SalesSubscription.SoldVehicle), returnSubscription);
            return vehicle;
        }
    }
}
