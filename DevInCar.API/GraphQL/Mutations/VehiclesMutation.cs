using DevInCar.API.DTOs;
using DevInCar.API.Models;
using DevInCar.API.Repositories;
using DevInCar.API.Services;
using HotChocolate.Subscriptions;

namespace DevInCar.API.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VehiclesMutation
    {
        public async Task<bool> CreateVehicle([Service] IVehicleService service, CarDTO input, [Service] ITopicEventSender eventSender)
        {
            await eventSender.SendAsync(input.vehicleType, input);
            return service.AddVehicle(input);        
        }

        public async Task<string> ChangeColor([Service] IVehicleService service, Guid id, string color, [Service] ITopicEventSender eventSender)
        {
            return service.ChangeColor(id, color);
        }

        public async Task<string> ChangeValue([Service] IVehicleService service, Guid id, double value, [Service]ITopicEventSender eventSender)
        {
            return service.ChangeValue(id, value);
        }
    }
}
 