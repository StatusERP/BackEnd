using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("ExistenciaLotes", Schema = Constants.Conjunto)]
    public class ExistenciaLote:EntityBase
    {
        [Required(ErrorMessage = "Se debe indicar una Bodega.")]
        public int Bodega { get; set; }
        
        [Required(ErrorMessage = "Se debe indicar un código de artículo")]
        public int Articulo { get; set; }
        
        [Required(ErrorMessage = "Se debe indicar una localización")]
        public int Localización { get; set; }
        
        [Required(ErrorMessage = "Se debe indicar un código de lote")]
        public int Lote { get; set; }
        
        [Required(ErrorMessage = "Se requiere ingresar la cantidad disponible.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantDisponible { get; set; }
        
        [Required(ErrorMessage = "Se requiere ingresar la cantidad reservada.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantReservada { get; set; }
        
        [Required(ErrorMessage = "Se requiere ingresar la cantidad no aprobada.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantNoAprobada { get; set; }
        
        [Required(ErrorMessage = "Se requiere ingresar la cantidad vencida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantVencida { get; set; }
        
        [Required(ErrorMessage = "Se requiere ingresar la cantidad remitida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantRemitida { get; set; }
        
        [Required(ErrorMessage = "Se requiere ingresar el costo unitario en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoUntLoc { get; set; }
        
        [Required(ErrorMessage = "Se requiere ingresar el costo unitario en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoUntDol { get; set; }
    }
}
