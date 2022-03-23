using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("ReglasDescuento", Schema = Constants.Conjunto)]
    public class ReglaDescuento: EntityBase 
    {
        [Required(ErrorMessage = "El código de la regla de descuento es requerido.") ]
        public int CodReglaDescuento { get; set; }

        [Required(ErrorMessage = "La descrición de la regla de descuento es requerida.")]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public bool Activa { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? Descuento { get; set; }

        public int ? Prioridad { get; set; }

        [StringLength(8)]
        public string ? CategoriaCliente { get; set; }

        [StringLength(20)]
        public string ? Cliente { get; set; }

        [StringLength(12)]
        public string ? Clasificacion { get; set; }

        [StringLength(20)]
        public string ? Articulo { get; set; }

        [StringLength(20)]
        public string ? ArticuloPatron { get; set; }

        public string ? Notas { get; set; }

        [Required(ErrorMessage = "El tipo de descuento es requerido.")]
        [StringLength(1)]
        public string TipoDescuento { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CantidadCompra { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CantidadFacturar { get; set; }

        [StringLength(12)]
        public string ? Clasificacion2 { get; set; }

        [StringLength(12)]
        public string ? Clasificacion3 { get; set; }

        [StringLength(12)]
        public string ? Clasificacion4 { get; set; }

        [StringLength(12)]
        public string ? Clasificacion5 { get; set; }

        [StringLength(12)]
        public string ? Clasificacion6 { get; set; }

        public bool RequiereAutorizacion { get; set; }

        [StringLength(4)]
        public string ? FormaPago { get; set; }

        [StringLength(20)]
        public string ? DetalleFormaPago { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MinimoDocumento { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MinimoPago { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DescFormaPago { get; set; }
    }
}
