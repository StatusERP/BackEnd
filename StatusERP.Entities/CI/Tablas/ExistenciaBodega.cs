using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("ExistenciaBodega", Schema = Constants.Conjunto)]
    //[Index(nameof(ArticuloId), nameof(BodegaId), IsUnique = true)]
    public class ExistenciaBodega:EntityBase
    {
        public int ArticuloId { get; set; }
        public Articulo articulo { get; set; }
        
        public int BodegaId { get; set; }
        public Bodega bodega { get; set; }
                
        [Column(TypeName = "decimal(28,8)")]
        public decimal ExistenciaMinima { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal ExistenciaMaxima { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal PuntoDeOrden { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantDisponible { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantReservada { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantNoAprobada { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantVencida { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantTransito { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantProduccion { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantPedida { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantRemitida { get; set; }
        
        public bool Congelado { get; set; }
        
        public DateTime ? FechaCong { get; set; }
        
        public bool BloqueaTrans { get; set; }
        
        public DateTime ? FechaDescong { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoUntPromedioLoc { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoUntPromedioDol { get; set; }
   }
}
