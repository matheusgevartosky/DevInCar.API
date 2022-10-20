using DevInCar.API.DTOs;
using DevInCar.API.GraphQL.Subscriptions;
using DevInCar.API.Models;
using DevInCar.API.Services;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Subscriptions;

namespace DevInCar.API.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VehiclesMutation
    {
        [Authorize]
        [GraphQLName("add_car")]
        public async Task<bool> AddCarMutation([Service] IVehicleService service, CarDTO input, [Service] ITopicEventSender eventSender)
        {
            Vehicle vehicle = (Vehicle)input;
            var returnSubscription = new SubscriptionView(vehicle);
            await eventSender.SendAsync(returnSubscription.VehicleType, returnSubscription).ConfigureAwait(false);
            try
            {
                await eventSender.SendAsync(nameof(VehiclesSubscription.addedVehicle), returnSubscription).ConfigureAwait(false);
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
            return service.AddVehicle(vehicle);
 
        }
        [Authorize]
        [GraphQLName("add_truck")]
        public async Task<bool> AddTruckMutation([Service] IVehicleService service, TruckDTO input, [Service] ITopicEventSender eventSender)
        {
            Vehicle vehicle = (Vehicle)input;
            var returnSubscription = new SubscriptionView(vehicle);
            await eventSender.SendAsync(vehicle.VehicleType, returnSubscription).ConfigureAwait(false);
            await eventSender.SendAsync(nameof(VehiclesSubscription.addedVehicle), returnSubscription).ConfigureAwait(false);
            return service.AddVehicle(vehicle);

        }
        [Authorize]
        [GraphQLName("add_mothorcicle")]
        public async Task<bool> AddMothrcicleMutation([Service] IVehicleService service, MotorcicleDTO input, [Service] ITopicEventSender eventSender)
        {
            Vehicle vehicle = (Vehicle)input;
            var returnSubscription = new SubscriptionView(vehicle);
            await eventSender.SendAsync(vehicle.VehicleType, returnSubscription).ConfigureAwait(false);
            await eventSender.SendAsync(nameof(VehiclesSubscription.addedVehicle), returnSubscription).ConfigureAwait(false);
            return service.AddVehicle(vehicle);
        }

        [GraphQLName("change_color")]
        public async Task<string> ChangeColor([Service] IVehicleService service, string id, string color, [Service] ITopicEventSender eventSender)
        {
            return service.ChangeColor(id, color);
        }

        [GraphQLName("change_value")]
        public async Task<string> ChangeValue([Service] IVehicleService service, string id, double value, [Service]ITopicEventSender eventSender)
        {
            return service.ChangeValue(id, value);
        }
    }
}
 