using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoMovInventarioEnc
    {
        public int Id { get; set; }

        public int? ConsecutivoId { get; set; }

        [Required(ErrorMessage = "Debe indicarse el usuario.")]
        [StringLength(25)]
        public string Usuario { get; set; }

        public DateTime FechaHora { get; set; }

        [Required(ErrorMessage = "Debe indicarse el módulo origen.")]
        [StringLength(4)]
        public string ModuloOrigen { get; set; }

        //[Required(ErrorMessage = "Debe indicarse la aplicación.")]
        //[StringLength(250)]
        //public string Aplicacion { get; set; }

        [Required(ErrorMessage = "Debe indicarse la referencia.")]
        [StringLength(200)]
        public string Referencia { get; set; }

        [StringLength(10)]
        public string? Asiento { get; set; }

        [StringLength(25)]
        public string? UsuarioAprob { get; set; }
        public DateTime? FechaHoraAprob { get; set; }

        [StringLength(4)]
        public String? PaqueteInventario { get; set; }

        public List<Detalle>  Detalle { get; set; } 
    }

    public class Detalle
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

        [StringLength(1)]
        public string Tipo { get; set; }

        [StringLength(1)]
        public string Subtipo { get; set; }

        [StringLength(1)]
        public string Subsubtipo { get; set; }

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
