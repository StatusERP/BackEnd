using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;

// Esta tabla guarda relación Encabezado-Detalle con la tabla ArticuloPrecio.  Esta tabla es el encabezado.

namespace StatusERP.Entities.FA.Tablas
{
    [Table("VersionesNivelPrecio", Schema = Constants.Conjunto)]
    public class VersionNivelPrecio : EntityBase
    {
        public int NivelPrecioId { get; set; }
        [ForeignKey(nameof(NivelPrecioId))]
        public NivelPrecio NivelPrecio { get; set; }

        public int Version { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaCorte { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        [StringLength(250)]
        public string  UsuarioCreacion {get; set; }

        public DateTime FechaHoraCreacion { get; set; }

        [StringLength(250)]
        public string ? UsuarioUltModif { get; set; }

        public DateTime ? FechaHoraUltModif { get; set; }

        [StringLength(250)]
        public string ? UsuarioAprobacion { get; set; }  

        public DateTime ? FechaHoraAprobacion { get; set; }

        [StringLength(250)]
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
