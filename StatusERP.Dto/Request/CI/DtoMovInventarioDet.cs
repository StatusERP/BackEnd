using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoMovInventarioDet
    {
        public int MovInventarioEncId { get; set; }

        public int Consecutivo { get; set; }

        public DateTime? FechaHoraTransac { get; set; }

        public int? DocTributarioId { get; set; }

        public int? AjusteConfigId { get; set; }

        public int ArticuloId { get; set; }

        public int? BodegaId { get; set; }

        public int? LocalizacionId { get; set; }

        public int? LoteId { get; set; }

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

        [Column(TypeName = "decimal(28,8)")]
        public decimal Cantidad { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotLoc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotDol { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalDolar { get; set; }

        public bool Contabilizada { get; set; }

        public DateTime Fecha { get; set; }

        public int? CentroCuentaId { get; set; }

        public int? UnidadDistribucionId { get; set; }

        [StringLength(10)]
        public string? AsientoCardex { get; set; }

        [StringLength(50)]
        public string? DocFiscal { get; set; }

        public int? TipoOperacionId { get; set; }

        public int? TipoPagoId { get; set; }
    }
}
