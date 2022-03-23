using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("VersionesNivelPrecio", Schema = Constants.Conjunto)]
    public class VersionNivelPrecio : EntityBase
    {
        [Required(ErrorMessage = "El nombre de Nivel Precio es requerido.")]
        [StringLength(12)]
        public string NivelPrecio { get; set; }

        [Required(ErrorMessage = "La moneda es requerida.")]
        [StringLength(1)]
        public string Moneda { get; set; }

        [Required(ErrorMessage = "El número de versión es requerido.")]
        public int Version { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es requerida.")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "La fecha de corte es requerida.")]
        public DateTime FechaCorte { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "El usuario de creación es requerido.")]
        [StringLength(25)]
        public string  UsuarioCreacion {get; set; }

        [Required(ErrorMessage = "La fecha y hora de creación son requeridas.")]
        public DateTime FechaHoraCreacion { get; set; }

        [StringLength(25)]
        public string ? UsuarioUltModif { get; set; }

        public DateTime ? FechaHoraUltModif { get; set; }

        [StringLength(25)]
        public string ? UsuarioAprobacion { get; set; }  

        public DateTime ? FechaHoraAprobacion { get; set; }

        [StringLength(25)]
        public string ? UsuarioAnulacion { get; set; }

        public DateTime ? FechaHoraAnulacion { get; set;}

        [StringLength(10)]
        public string ? Identificador { get; set; }

        public bool Impuesto1Incluido { get; set; }

        [StringLength(4)]
        public string ? PrecioReferenciaDE { get; set; }

        public bool SincMovil { get; set; }
     }
}
