using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoMetodoPago
    {

        [Required(ErrorMessage = "Se requiere especificar el código del Método de Pago.")]
        [StringLength(4)]
        public string CodMetodoPago { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la descripción del Método de Pago.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }
    }
}
