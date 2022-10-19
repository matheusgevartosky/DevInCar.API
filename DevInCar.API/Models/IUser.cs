using System.ComponentModel.DataAnnotations;

namespace DevInCar.API.Models
{
    public interface IUser
    {
        string EmailAddress { get; set; }
        string Id { get; set; }
        string Name { get; set; }
        string Password { get; set; }
    }
}