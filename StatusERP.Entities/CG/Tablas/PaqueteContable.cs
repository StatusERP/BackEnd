using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("PaquetesContables", Schema = Constants.Conjunto)]
    public class PaqueteContable:EntityBase
    {
        [Required(ErrorMessage = "Se debe indicar el código del Paquete Contable")]
        [StringLength(4)]
        public string CodPaquete { get; set; }

        [Required(ErrorMessage = "Se debe indicar la Descripción del Paquete Contable")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Usuario Creador es requerido.")]
        [StringLength(25)]
        public string UsuarioCreador { get; set; }

        [Required(ErrorMessage = "Ultimo Usuario es requerido")]
        [StringLength(25)] 
        public string UltimoUsuario { get; set; }

        [Required(ErrorMessage = "Fecha Ultimo Acceso es requerida.")]
        public DateTime FechaUltAcceso { get; set; }

        [Required(ErrorMessage = "Ultimo Asiento Fiscal es requerido.")]
        [StringLength(10)]
        public string UltimoAsientoFiscal { get; set; }

        [StringLength(10)]
        public string ? UltimoAsientoCorp { get; set; }

        [Required]
        public bool Marcado { get; set; }
    }
}
