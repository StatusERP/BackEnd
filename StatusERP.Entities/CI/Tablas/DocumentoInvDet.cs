using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StatusERP.Entities.CI.Tablas
{
    [Table("DocumentosInvDet", Schema = Constants.Conjunto)]
    public class DocumentoInvDet:EntityBase
    {
        [Required(ErrorMessage ="El paquete de inventario es requerido.")]
        [StringLength(4)]
        public string PaqueteInventario { get; set; }

        [Required(ErrorMessage = "El número de documento es requerido.")]
        [StringLength(50)]
        public string DocumentoInv { get; set; }

        [Required(ErrorMessage = "El número de línea del documento es requerido.")]
        public int LineaDocInv { get; set; }

        [Required(ErrorMessage = "El código de ajuste configurable es requerido.")]
        [StringLength(4)]
        public string AjusteConfig { get; set; }

        [StringLength(20)]
        public string ? DocTributario { get; set; }

        [Required(ErrorMessage = "El artículo es requerido.")]
        [StringLength(20)]
        public string Articulo { get; set; }

        [StringLength(4)]
        public string ? Bodega { get; set; }

        [StringLength(8)]
        public string ? Localización { get; set; }

        [StringLength(15)]
        public string ? Lote { get; set; }

        [Required(ErrorMessage = "El tipo es requerido.")]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El subtipo es requerido.")]
        [StringLength(1)]
        public string Subtipo { get; set; }

        [Required(ErrorMessage = "El subsubtipo es requerido.")]
        [StringLength(1)]
        public string Subsubtipo { get; set;}

        [Required(ErrorMessage = "Se requiere especificar la cantidad.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Cantidad { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el costo total en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotalLocal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el costo total en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotalDolar { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el precio total en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalLocal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el precio total en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalDolar { get; set; }

        [StringLength(4)]
        public string ? BodegaDestino { get; set; }

        [StringLength(8)]
        public string ? LocalizacionDest { get; set; }

        [StringLength(25)]
        public string ? CentroCosto { get; set; }
        
        public DateTime ? Secuencia { get; set; }
        
        public int ? SerieCadena { get; set; }

        [StringLength(6)]
        public string ? UnidadDistribucio { get; set; }

        [StringLength(25)]
        public string ? CuentaContable { get; set; }

        [StringLength(50)]
        public string ? CAI { get; set; }

        [StringLength(4)]
        public string ? TipoOperacion { get; set; }

        [StringLength(10)]
        public string ? TipoPago { get; set; }
     }
}
