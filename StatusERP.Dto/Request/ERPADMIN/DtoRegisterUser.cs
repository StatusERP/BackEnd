using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.ERPADMIN
{
    public class DtoRegisterUser
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="El Correo no tiene el formato correcto")]
        public string email { get; set; }
        public int Age { get; set; }
        public int TypeDocument { get; set; }
        [Required]
        public string  DocumentoNumber { get; set; }
        [Required]
        [Compare(nameof(ConfirmPassword),ErrorMessage ="Las Claves no Coinciden")]
        public string Password { get; set; }
        [Required]
        public string  ConfirmPassword { get; set; }
    }
}
