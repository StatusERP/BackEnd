using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("DesBonEscalaBonificacion", Schema = Constants.Conjunto)]
    public class DesBonEscalaBonificacion: EntityBase
    {
        [Required(ErrorMessage = "La regla es requerida." )]
        [StringLength(20)]
        public string Regla { get; set; }

        [StringLength(20)]
        public String ? Articulo { get; set; }

        [Required(ErrorMessage = "La cantidad mínima es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadMinima { get; set; }

        [Required(ErrorMessage = "La cantidad máxima es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadMaxima { get; set; }

        [Required(ErrorMessage = "El factor es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Factor { get; set; }

        [Required(ErrorMessage = "La cantidad inicial es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadInicial { get; set; }

        [Required(ErrorMessage = "La cantidad pedida es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadPedida { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? UnidadAlmacen { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? UnidadDetalle { get; set; }

        [Required(ErrorMessage = "La cantidád mínima de detalle es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantMinimaDet { get; set; }

        [Required(ErrorMessage = "La cantidád máxima de detalle es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantMaximaDet { get; set; }

        [Required(ErrorMessage = "El factor de detalle es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal FactorDet { get; set; }

        [Required(ErrorMessage = "La cantidád inicial de detalle es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadInicialDet { get; set; }

        [Required(ErrorMessage = "La cantidád inicial de consolidación es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadInicialConsol { get; set; }
    }
}
