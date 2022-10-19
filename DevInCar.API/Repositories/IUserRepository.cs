using DevInCar.API.DTOs;
using DevInCar.API.Models;

namespace DevInCar.API.Repositories
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        User? Authentication(LoginDTO userDto);
        IEnumerable<User?> getUser(string id);
    }
}