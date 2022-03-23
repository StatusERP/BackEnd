using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("ArticuloPrecios", Schema = Constants.Conjunto)]
    public class ArticuloPrecio:EntityBase
    {
        [Required(ErrorMessage = "El código de Nivel de Precio es requerido.")]
        [StringLength(12)]
        public string NivelPrecio { get; set; }
        
        [Required(ErrorMessage = "La moneda es requerida.")]
        [StringLength(1)]
        public string Moneda { get; set; }
        
        [Required(ErrorMessage = "La versión es requerida.")]
        public int Version { get; set; }
        
        [Required(ErrorMessage = "El artículo es requerido.")]
        [StringLength(20)]
        public string Articulo { get; set; }
        
        [Required(ErrorMessage = "La versión del artículo es requerida.")]
        public int VersionArticulo { get; set; }
        
        [Required(ErrorMessage = "El precio es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Precio { get; set; }
        
        [Required(ErrorMessage = "El esquema de trabajo es requerido.")]
        [StringLength(1)]
        public string EsquemaTrabajo { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MargenMULR { get; set; }
        
        [Required(ErrorMessage = "El margen de utilidad es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MargenUtilidad { get; set; }
        
        [Required(ErrorMessage = "La fecha de inicio es requerida.")]
        public DateTime FechaInicio { get; set; }
        
        [Required(ErrorMessage = "La fecha final es requerida.")]
        public DateTime FechaFin { get; set; }
        
        public DateTime ? FechaUltModif { get; set; }
        
        [StringLength(25)]
        public string?  UsuarioUltModif { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MargenUtilidadMin { get; set; }
    }
}
