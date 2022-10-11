using DevInCar.API.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace DevInCar.API.Models
{
    public class Vehicle : IVehicle
    {
        public Vehicle(string id, string? buyerId, Guid chassisNumber, string color, FuelType fuelType, DateTime manufacturingDate,
                       string name, string plateNumber, double potency,
                       VehicleType type, double value, bool status = true, int loadingCapacity = 0, int doorsNumber = 0)
        {
            Id = id;
            BuyerId = buyerId;
            ChassisNumber = chassisNumber;
            Color = color;
            DoorsNumber = doorsNumber;
            FuelType = fuelType;
            ManufacturingDate = manufacturingDate;
            Name = name;
            PlateNumber = plateNumber;
            Potency = potency;
            Status = status;
            Type = type;
            Value = value;
            LoadingCapacity = loadingCapacity;
        }

        [Key]
        public string Id { get; set; }
        public string? BuyerId { get; set; }

        public Guid ChassisNumber { get; set; }

        public string Color { get; set; }

        public int DoorsNumber { get; set; }

        public FuelType FuelType { get; set; }

        public DateTime ManufacturingDate { get; set; }

        public string Name { get; set; }

        public string PlateNumber { get; set; }

        public double Potency { get; set; }

        public bool Status { get; set; }

        public VehicleType Type { get; set; }

        public double Value { get; set; }
        public int LoadingCapacity { get; set; }





    }
}
