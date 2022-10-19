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
        public async Task<bool> AddCarMutation([Service] IVehicleService service, CarDTO carDto, [Service] ITopicEventSender eventSender)
        {
            Vehicle vehicle = (Vehicle)carDto;
            var returnSubscription = new SubscriptionView(vehicle);
            await eventSender.SendAsync(vehicle.VehicleType, returnSubscription);
            await eventSender.SendAsync(nameof(VehiclesSubscription.addedVehicle), returnSubscription);
            return service.AddVehicle(vehicle);
 
        }
        [Authorize]
        public async Task<bool> AddTruckMutation([Service] IVehicleService service, TruckDTO truckDto, [Service] ITopicEventSender eventSender)
        {
            Vehicle vehicle = (Vehicle)truckDto;
            var returnSubscription = new SubscriptionView(vehicle);
            await eventSender.SendAsync(vehicle.VehicleType, returnSubscription);
            await eventSender.SendAsync(nameof(VehiclesSubscription.addedVehicle), returnSubscription);
            return service.AddVehicle(vehicle);

        }
        [Authorize]
        public async Task<bool> AddMothrcicleMutation([Service] IVehicleService service, MotorcicleDTO motorcicleDto, [Service] ITopicEventSender eventSender)
        {
            Vehicle vehicle = (Vehicle)motorcicleDto;
            var returnSubscription = new SubscriptionView(vehicle);
            await eventSender.SendAsync(vehicle.VehicleType, returnSubscription);
            await eventSender.SendAsync(nameof(VehiclesSubscription.addedVehicle), returnSubscription);
            return service.AddVehicle(vehicle);
        }

       
        public async Task<string> ChangeColor([Service] IVehicleService service, string id, string color, [Service] ITopicEventSender eventSender)
        {
            return service.ChangeColor(id, color);
        }

        public async Task<string> ChangeValue([Service] IVehicleService service, string id, double value, [Service]ITopicEventSender eventSender)
        {
            return service.ChangeValue(id, value);
        }
    }
}
 