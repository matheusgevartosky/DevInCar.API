using DevInCar.API.Data.Seeds;
using DevInCar.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DevInCar.API.Data.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(Seeders.VehiclesSeeder);
        }
    }
}
