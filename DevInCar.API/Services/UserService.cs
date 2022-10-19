using DevInCar.API.DTOs;
using DevInCar.API.Models;
using DevInCar.API.Repositories;

namespace DevInCar.API.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CreateUser(User user)
        {
            return _userRepository.AddUser(user);
        }

        public User? GetUser(string id)
        {
            return _userRepository.getUser(id);
        }

        public User? AuthenticateUser(LoginDTO dto)
        {
            return _userRepository.Authentication(dto);
        }
    }
}
