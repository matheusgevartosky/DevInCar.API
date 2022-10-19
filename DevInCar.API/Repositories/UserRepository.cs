using DevInCar.API.Data.Context;
using DevInCar.API.DTOs;
using DevInCar.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DevInCar.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbContextFactory<Context> _dbContextFactory;

        public UserRepository(IDbContextFactory<Context> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public bool AddUser(User user)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Add(user);
                return context.SaveChanges() != 0;
            }
        }

        public IEnumerable<User?> getUser(string? id)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                if(id != null)
                {
                    var users = context.Users.Where(x => x.Id == id).ToList();
                    return users;
                }
                return context.Users.ToList();
            }
        }

        public User? Authentication(LoginDTO userDto)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var user = context.Users.Where(x => x.EmailAddress == userDto.Email
                && x.Password == userDto.Password).FirstOrDefault();

                return user;
            }
        }

    }
}
