using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("FlujosCaja", Schema = Constants.Conjunto)]
    public class FlujoCaja:EntityBase
    {
        public bool Activo { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La fecha de creación es requerida.")]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "La fecha final es requerida.")]
        public DateTime FechaFinal { get; set; }

        [Required(ErrorMessage = "La fecha inicial es requerida.")]
        public DateTime FechaInicial { get; set; }

        public DateTime ? FechaModificacion { get; set; }

        [Required(ErrorMessage = "Debe indicarse un código de flujo de caja.")]
        [StringLength(20)]
        public string FlujoCajaCod { get; set; }

        public string ? Notas { get; set; }

        [Required(ErrorMessage = "El tipo de periodo es requerido.")]
        [StringLength(1)]
        public string TipoPeriodo { get; set; }

        [Required(ErrorMessage = "El usuario creación es requerido.")]
        [StringLength(450)]
        public string UsuarioCreacion { get; set; }

        [StringLength(450)]
        public string ? UsuarioModificacion { get; set; }
    }
}
