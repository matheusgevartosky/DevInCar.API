using DevInCar.API.DTOs;
using DevInCar.API.Models;

namespace DevInCar.API.Services
{
    public interface IUserService
    {
        User? AuthenticateUser(LoginDTO dto);
        bool CreateUser(User user);
        User? GetUser(string id);
    }
}