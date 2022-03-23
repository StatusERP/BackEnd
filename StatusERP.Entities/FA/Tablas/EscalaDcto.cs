using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("EscalasDcto", Schema = Constants.Conjunto)]
    public class EscalaDcto : EntityBase
    {
        [Required(ErrorMessage ="El nivel de precios es requerido.")]
        [StringLength (12)]
        public string NivelPrecio { get; set; }

        [Required(ErrorMessage = "La moneda es requerida.")]
        [StringLength(1)]
        public string Moneda { get; set; }

        [Required(ErrorMessage = "La versión es requerida.")]
        public int Version { get; set; }

        [Required(ErrorMessage = "El artículo es requerido.")]
        [StringLength(20)]
        public string Articulo { get; set; }

        [Required(ErrorMessage = "El código de la escala de descuento es requerido.")]
        public int CodEscalaDcto { get; set; }

        [Required(ErrorMessage = "La versión de la escala de descuento es requerida.")]
        public int VersionDcto { get; set; }

        public int ? MinUnidFact { get; set; }

        public int ? MaxUnidFact { get; set; }

        [Required(ErrorMessage = "El porcentaje de descuento es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcDcto { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es requerida.")]
        public DateTime FechaInicioEsc { get; set; }

        [Required(ErrorMessage = "La fecha fin es requerida.")]
        public DateTime FechaFinEsc { get; set; }

        public DateTime ? FechaUltModif { get; set; }

        [StringLength(25)]
        public string ? UsuarioUltModif { get; set; }    
    }
}
