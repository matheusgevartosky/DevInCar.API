using DevInCar.API.DTOs;
using DevInCar.API.Models;

namespace DevInCar.API.Repositories
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        User? Authentication(LoginDTO userDto);
        User? getUser(string id);
    }
}