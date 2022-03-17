using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("MovsInventarioDet", Schema = Constants.Conjunto)]
    public class MovInventarioDet:EntityBase
    {
        [Required(ErrorMessage = "El consecutivo es requerido.")]
        public int Consecutivo { get; set; }

        public DateTime ? FechaHoraTransac {get; set; }

        [StringLength(20)]
        public string ? DocTributario { get; set; }

        [StringLength(4)]
        public string ? AjusteConfig { get; set; }

        [Required(ErrorMessage = "El artículo es requerido.")]
        [StringLength(20)]
        public string Articulo { get; set; }

        [StringLength(4)]
        public string ? Bodega { get; set; }

        [StringLength(8)]
        public string ? Localizacion { get; set;}

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
        public string Subsubtipo { get; set; }

        [Required(ErrorMessage = "La naturaleza es requerida.")]
        [StringLength(1)]
        public string Naturaleza { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Cantidad { get; set; }

        [Required(ErrorMessage = "El costo total en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotLoc { get; set; }

        [Required(ErrorMessage = "El costo total en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotDol { get; set; }

        [Required(ErrorMessage = "El precio total en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalLocal { get; set; }

        [Required(ErrorMessage = "El precio total en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalDolar { get; set; }

        public bool Contabilizada { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [StringLength(25)]
        public string ? CentroCosto { get; set; }

        [StringLength(6)]
        public string ? UnidadDistribucion { get; set; }

        [StringLength(25)]
        public string ? CuentaContable { get; set; }

        [StringLength(10)]
        public string ? AsientoCardex { get; set; }

        [StringLength(50)]
        public string ? DocFiscal { get; set; }

        [StringLength(4)]
        public string ? TipoOperacion { get; set; }

        [StringLength(10)]
        public string ? TipoPago { get; set; }           
    }
}
