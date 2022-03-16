using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("ExistenciaBodega", Schema = Constants.Conjunto)]
    public class ExistenciaBodega:EntityBase
    {
        [Required(ErrorMessage = "El articulo es requerido.")]
        [StringLength(20)]
        public string Articulo { get; set; }
        
        [Required(ErrorMessage = "La bodega es requerida.")]
        [StringLength(4)]
        public string Bodega { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la existencia mínima.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ExistenciaMinima { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la existencia máxima.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ExistenciaMaxima { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse el punto de reorden.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PuntoDeOrden { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la cantidad disponible.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantDisponible { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la cantidad reservada.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantReservada { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la cantidad no aprobada.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantNoAprobada { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la cantidad vencida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantVencida { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la cantidad en tránsito.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantTransito { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la cantidad producción.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantProduccion { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la cantidad pedida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantPedida { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse la cantidad remitida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantRemitida { get; set; }
        
        public bool Congelado { get; set; }
        
        public DateTime ? FechaCong { get; set; }
        
        public bool BloqueaTrans { get; set; }
        
        public DateTime ? FechaDescong { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse el costo promedio unitario en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoUntPromedioLoc { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse el costo promedio unitario en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoUntPromedioDol { get; set; }
   }
}
