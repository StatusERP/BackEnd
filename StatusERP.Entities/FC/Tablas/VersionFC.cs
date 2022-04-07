using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("VersionesFC", Schema = Constants.Conjunto)]
    public class VersionFC:EntityBase
    {
        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        public DateTime ? FechaCalculo { get; set; }

        [Required(ErrorMessage = "La fecha creación es requerida.")]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "La fecha final es requerida.")]
        public DateTime FechaFinal { get; set; }

        public DateTime ? FechaHistorico { get; set; }

        [Required(ErrorMessage = "La fecha inicial es requerida.")]
        public DateTime FechaInicial { get; set; }

        public DateTime ? FechaModificacion { get; set; }

        [Required(ErrorMessage = "Debe indicarse un número de flujo de caja.")]
        public int FlujoCajaId { get; set; }
        public FlujoCaja FlujoCaja { get; set; }

        [Required(ErrorMessage = "El usuario de cálculo es requerido.")]
        [StringLength(450)]
        public string UsuarioCalculo { get; set; }

        [Required(ErrorMessage = "El usuario creación es requerido.")]
        [StringLength(450)]
        public string UsuarioCreacion { get; set; }

        [Required(ErrorMessage = "El usuario histórico es requerido.")]
        [StringLength(450)]
        public string UsuarioHistorico { get; set; }

        [Required(ErrorMessage = "El usuario modificación es requerido.")]
        [StringLength(450)]
        public string UsuarioModificacion { get; set; }

        [Required(ErrorMessage = "La versión es requerida.")]
        public int Version { get; set; }

    }
}
