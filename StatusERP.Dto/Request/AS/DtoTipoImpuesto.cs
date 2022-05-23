using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoTipoImpuesto
    {
        [Required(ErrorMessage = "Se requiere especificar el código del tipo de impuesto.")]
        [StringLength(4)]
        public string CodTipoImpuesto { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la descripción del tipo de impuesto.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }
    }
}
