using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoVendedor
    {

        [Required(ErrorMessage = "Se requiere especificar el código del Vendedor.")]
        [StringLength(4)]
        public string CodVendedor { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre del Vendedor.")]
        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string? Email { get; set; }

        [StringLength(15)]
        public string? Telefono { get; set; }

        public bool Activo { get; set; }
    }
}
