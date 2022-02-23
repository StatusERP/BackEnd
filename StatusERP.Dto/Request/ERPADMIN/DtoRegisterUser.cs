using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Dto.Request.ERPADMIN
{
    public class DtoRegisterUser
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        public int Age { get; set; }
        public int TypeDocument { get; set; }
        [Required]
        public string  DocumentoNumber { get; set; }
        [Required]
        [Compare(nameof(ConfirmPassword))]
        public string Password { get; set; }
        [Required]
        public string  ConfirmPassword { get; set; }
    }
}
