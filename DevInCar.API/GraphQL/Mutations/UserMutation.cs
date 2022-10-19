using DevInCar.API.DTOs;
using DevInCar.API.Models;
using DevInCar.API.Services;
using HotChocolate.AspNetCore.Authorization;

namespace DevInCar.API.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class UserMutation
    {
        public async Task<bool> CreateUser([Service] IUserService service, UserDTO dto)
        {
            User user = (User)dto;
            return service.CreateUser(user);
        }

        [Authorize]
        public async Task<User?> GetUser([Service] IUserService service, string? id)
        {
            return service.GetUser(id);
        }
    }
}
