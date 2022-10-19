using DevInCar.API.Models.Enum;
using HotChocolate.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace DevInCar.API.Models
{
    public class Vehicle : IVehicle
    {
        [Key]
        public string Id { get; set; }
        public string? BuyerId { get; set; }
        [Authorize]
        [Required(ErrorMessage = "O Campo chassis é obrigatório.")]
        public string ChassisNumber { get; set; }

        [Required(ErrorMessage = "O Campo cor é obrigatório.")]
        public string Color { get; set; }
        public int? DoorsNumber { get; set; }

        [Required(ErrorMessage = "O Campo combustivel é obrigatório.")]
        public FuelType FuelType { get; set; }
        public int? LoadingCapacity { get; set; }

        [Required(ErrorMessage = "O Campo data de fabricação é obrigatório.")]
        public string ManufacturingDate { get; set; }

        [Required(ErrorMessage = "O Campo nome é obrigatório.")]
        [StringLength(255, ErrorMessage = "O tamanho máximo do campo nome é de 255 caracteres")]
        public string Name { get; set; }

        [Authorize]
        [Required(ErrorMessage = "O campo placa é obrigatório.")]
        [StringLength(10, ErrorMessage = "O tamanho máximo do campo nome é de 10 caracteres")]
        public string PlateNumber { get; set; }

        [Required(ErrorMessage = "O Campo potencia é obrigatório.")]
        public double Potency { get; set; }
        public string SaleDate { get; set; }

        [Required(ErrorMessage = "O Campo Status é obrigatório.")]
        public bool Status { get; set; }
        public VehicleType VehicleType { get; set; }

        [Required(ErrorMessage = "O Campo valor é obrigatório.")]
        public double Value { get; set; }

        [Required(ErrorMessage = "O Campo rodas é obrigatório.")]
        public int WheelsNumber { get; set; }

    }
}