using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("Articulos", Schema = Constants.Conjunto)]
    public class Articulo : EntityBase
    {
        [Required(ErrorMessage = "El código del artículo es requerido.")]
        [StringLength(20)]
        public string CodArticulo { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(12)] public string Clasificacion1 { get; set; }

        [StringLength(12)] public string Clasificacion2 { get; set; }

        [StringLength(12)] public string Clasificacion3 { get; set; }

        [StringLength(12)] public string Clasificacion4 { get; set; }

        [StringLength(12)] public string Clasificacion5 { get; set; }

        [StringLength(12)] public string Clasificacion6 { get; set; }

        [Column(TypeName = "decimal(28,8)")] public decimal FactorConver1 { get; set; }

        [Column(TypeName = "decimal(28,8)")] public decimal FactorConver2 { get; set; }

        [Column(TypeName = "decimal(28,8)")] public decimal FactorConver3 { get; set; }

        [Column(TypeName = "decimal(28,8)")] public decimal FactorConver4 { get; set; }

        [Column(TypeName = "decimal(28,8)")] public decimal FactorConver5 { get; set; }

        [Column(TypeName = "decimal(28,8)")] public decimal FactorConver6 { get; set; }

        [Required(ErrorMessage = "El tipo es requerido.")]
        [StringLength(1)]
        public string Tipo { get; set; }

        [StringLength(1)] public bool TiendaEnLinea { get; set; }

        [StringLength(1)] public bool VentaTarjetaCredito { get; set; }

        [Required(ErrorMessage = "Debe ingresar el peso neto.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PesoNeto { get; set; }

        [Required(ErrorMessage = "Debe ingresar el peso bruto.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PesoBruto { get; set; }

        [Required(ErrorMessage = "Debe ingresar el volumen.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Volumen { get; set; }

        [Required(ErrorMessage = "Debe ingresar los bultos.")]
        public Int16 Bultos { get; set; }

        [Required(ErrorMessage = "Debe ingresar la categoría del artículo.")]
        [StringLength(4)]
        public decimal CategoriaArticulo { get; set; }

        [Required(ErrorMessage = "Debe ingresar el impuesto.")]
        [StringLength(4)]
        public decimal Impuesto { get; set; }

        [Required(ErrorMessage = "Debe ingresar el factor de empaque.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal FactorEmpaque { get; set; }

        [Required(ErrorMessage = "Debe ingresar el factor de venta.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal FactorVenta { get; set; }

        [Required(ErrorMessage = "Debe ingresar la existencia mínima.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ExistenciaMínima { get; set; }

        [Required(ErrorMessage = "Debe ingresar la existencia máxima.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ExistenciaMáxima { get; set; }

        [Required(ErrorMessage = "Debe ingresar el punto de reorden.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PuntoDeOrden { get; set; }

        [Required(ErrorMessage = "Costo en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoLoc { get; set; }

        [Required(ErrorMessage = "Costo en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoDol { get; set; }

        [Required(ErrorMessage = "Precio base en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioBaseLocal { get; set; }

        [Required(ErrorMessage = "Precio base en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioBaseDol { get; set; }

        [Required(ErrorMessage = "La fecha de la última salida es requerida.")]
        public DateTime UltimaSalida { get; set; }
        
        [Required(ErrorMessage = "La fecha del último movimiento es requerida.")]
        public DateTime UltimoMovimiento { get; set; }
        
        [Required(ErrorMessage = "La fecha del último ingreso es requerida.")]
        public DateTime UltimoIngreso { get; set; }
        
        [Required(ErrorMessage = "La fecha del último inventario es requerida.")]
        public DateTime UltimoInventario { get; set; }
        
        [Required(ErrorMessage = "La clase ABC es requerida.")]
        [StringLength(1)]
        public string ClaseABC { get; set; }
        
        [Required(ErrorMessage = "La frecuencia de conteo es requerida.")]
        public Int16 FrecuenciaConteo { get; set; }
        
        [StringLength(20)]
        public string CodigoBarrasVent { get; set; }
        
        [StringLength(20)]
        public string CodigoBarrasAlm { get; set; }
        
        
    }
}
