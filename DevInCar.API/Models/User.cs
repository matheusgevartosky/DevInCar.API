using System.ComponentModel.DataAnnotations;

namespace DevInCar.API.Models
{
    public class User : IUser
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "O Campo nome é obrigatório.")]
        [StringLength(255, ErrorMessage = "O tamanho máximo do campo nome é de 255 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório")]
        [DataType(DataType.EmailAddress)]
        [StringLength(150, ErrorMessage = "O tamanho máximo do campo nome é de 255 caracteres")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "O tamanho máximo da senha deve ser de 50 carateres")]
        public string Password { get; set; }
    }
}
