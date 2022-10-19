using DevInCar.API.Models;
using System.ComponentModel.DataAnnotations;

namespace DevInCar.API.DTOs
{
    public class UserDTO
    {
        public string Name { get; set; }   
        public string Email { get; set; }
        public string Password { get; set; }

        public static explicit operator User(UserDTO dto)
        {
            return new User()
            {
                Name = dto.Name,
                EmailAddress = dto.Email,
                Password = dto.Password,
                Id = $"usr_{Guid.NewGuid()}"
            };
            
        }
    }
}
