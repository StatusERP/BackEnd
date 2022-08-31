using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.ERPADMIN.Tablas;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Entities.FA.Tablas
{
    [Table("ArticuloPrecios", Schema = Constants.Conjunto)]
    public class ArticuloPrecio:EntityBase
    {
        public int VersionNivelId { get; set; }
        [ForeignKey(nameof(VersionNivelId))]
        public VersionNivelPrecio VersionNivelPrecio { get; set; }

        public int ArticuloId { get; set; }
        [ForeignKey(nameof(ArticuloId))]
        public Articulo Articulo { get; set; }

        public int VersionArticulo { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal Precio { get; set; }
        
        [StringLength(1)]
        public string EsquemaTrabajo { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MargenMULR { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal MargenUtilidad { get; set; }
        
        public DateTime FechaInicio { get; set; }
        
        public DateTime FechaFin { get; set; }
        
        public DateTime ? FechaUltModif { get; set; }
        
        [StringLength(250)]
        public string ? UsuarioUltModif { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MargenUtilidadMin { get; set; }
    }
}
