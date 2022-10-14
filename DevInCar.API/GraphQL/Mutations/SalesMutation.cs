using DevInCar.API.DTOs;
using DevInCar.API.Services;
using HotChocolate.Subscriptions;

namespace DevInCar.API.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class SalesMutation
    {
        public async Task<bool> SellVehicle([Service] IVehicleService service, Guid id, string idComprador, DateOnly date ,[Service] ITopicEventSender eventSender)
        {
            //await eventSender.SendAsync();
            return service.SellVehicle(id, idComprador, date);
        }
    }
}
