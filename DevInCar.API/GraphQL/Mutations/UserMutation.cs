using DevInCar.API.DTOs;
using DevInCar.API.Models;
using DevInCar.API.Services;
using HotChocolate.AspNetCore.Authorization;

namespace DevInCar.API.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class UserMutation
    {
        public async Task<bool> CreateUser([Service] IUserService service, UserDTO input)
        {
            User user = (User)input;
            return service.CreateUser(user);
        }

        

    }
}
