using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("ExistenciaLotes", Schema = Constants.Conjunto)]
    public class ExistenciaLote:EntityBase
    {
        public int BodegaId { get; set; }
        public Bodega bodega { get; set; }
        
        public int ArticuloId { get; set; }
        public Articulo articulo { get; set; }
        
        public int LocalizacionId { get; set; }
        public Localizacion localizacion { get; set; }
        
        public int LoteId { get; set; }
        public Lote lote { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantDisponible { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantReservada { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantNoAprobada { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantVencida { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantRemitida { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoUntLoc { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoUntDol { get; set; }
    }
}
