using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StatusERP.Entities.CG.Tablas
{
    [Table("SeccionesCuentas", Schema = Constants.Conjunto)]
    public class SeccionCuenta: EntityBase
    {
        [Required(ErrorMessage= "El código de la sección es requerido." )]
        [StringLength(4)]
        public string CodSeccionCuenta { get; set; }

        [Required(ErrorMessage = "El tipo de la sección es requerido.")]
        [StringLength(1)]
        public string TipoSeccion { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [StringLength(40)]
        public string ? Acumulado { get; set; }

        [Required(ErrorMessage = "La secuencia es requerida.")]
        public Int16 Secuencia { get; set; }
    }
}
