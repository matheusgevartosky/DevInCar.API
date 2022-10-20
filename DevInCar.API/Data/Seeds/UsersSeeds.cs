using DevInCar.API.Models;

namespace DevInCar.API.Data.Seeds
{
    public class UsersSeeds
    {
        public static List<User> UserSeeder { get; set; } = new List<User>()
        {
            new User()
            {
                Name = "Yan",
                EmailAddress = "yan@devinhouse.com",
                Password= "yan123",
                Id = "1"

            },
            new User()
            {
                Name = "Administrador",
                EmailAddress= "admin@devinhouse.com",
                Password = "admin",
                Id = "2"
            }
        };
    }
}
