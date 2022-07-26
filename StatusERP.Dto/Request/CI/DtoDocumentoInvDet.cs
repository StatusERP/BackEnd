using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoDocumentoInvDet
    {
        public int PaqueteInventarioId { get; set; }

        [Required(ErrorMessage = "El número de documento es requerido.")]
        [StringLength(50)]
        public string DocumentoInv { get; set; }

        public int LineaDocInv { get; set; }

        public int AjusteConfigId { get; set; }

        public int? DocTributarioId { get; set; }

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

        [Column(TypeName = "decimal(28,8)")]
        public decimal Cantidad { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotalLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoTotalDolar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioTotalDolar { get; set; }

        public int? BodegaDestinoId { get; set; }

        public int? LocDestinoId { get; set; }

        public int? CentroCuentaId { get; set; }

        public DateTime? Secuencia { get; set; }

        public int? UnidadDistribucionId { get; set; }

        [StringLength(50)]
        public string? CAI { get; set; }

        public int? TipoOperacionId { get; set; }

        public int? TipoPagoId { get; set; }
    }
}

