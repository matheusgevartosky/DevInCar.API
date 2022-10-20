using DevInCar.API.Models.Enum;
using DevInCar.API.Models;

namespace DevInCar.API.DTOs
{
    public class MotorcicleDTO
    {
        public string color { get; set; }
        public DateOnly ManufacturingDate { get; set; }
        public string name { get; set; }
        public string plateNumber { get; set; }
        public MothorcicleType vehicleType { get; set; }
        public int potency { get; set; }
        public double value { get; set; }
        public int WheelsNumber { get; set; }

        public static explicit operator Vehicle(MotorcicleDTO dto)
        {
            return new Vehicle()
            {
                Name = dto.name,
                Color = dto.color,
                DoorsNumber = null,
                FuelType = FuelType.Gasolina,
                ManufacturingDate = dto.ManufacturingDate.ToString(),
                PlateNumber = dto.plateNumber,
                Potency = dto.potency,
                Value = dto.value,
                ChassisNumber = $"{Guid.NewGuid()}",
                SaleDate = "",
                Status = true,
                BuyerId = null,
                LoadingCapacity = null,
                VehicleType = (VehicleType)dto.vehicleType,
                Id = $"mt_{Guid.NewGuid()}",
                WheelsNumber = dto.vehicleType == MothorcicleType.Moto ? 2  :  3 
            };
        }
    }
}
