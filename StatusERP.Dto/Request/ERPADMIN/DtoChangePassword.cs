using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.ERPADMIN
{
    public record DtoChangePassword
    {
        [Required]
        public string Email { get; init; }
        [Required]
        public string OldPassword { get; init; }
        [Required]
        public string NewPassword { get; set; }
    }
}
