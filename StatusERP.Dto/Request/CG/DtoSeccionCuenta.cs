using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.CG
{
    public class DtoSeccionCuenta
    {
        [Required(ErrorMessage = "El código de la sección es requerido.")]
        [StringLength(4)]
        public string CodSeccionCuenta { get; set; }

        [Required(ErrorMessage = "El tipo de la sección es requerido.")]
        [StringLength(1)]
        public string TipoSeccion { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [StringLength(40)]
        public string? Acumulado { get; set; }

        [Required(ErrorMessage = "La secuencia es requerida.")]
        public Int16 Secuencia { get; set; }
    }
}
