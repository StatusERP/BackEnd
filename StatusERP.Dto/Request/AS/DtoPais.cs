using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoPais
    {
        [Required(ErrorMessage = "Se requiere especificar el código del País.")]
        [StringLength(4)]
        public string CodPais { get; set; }

        [StringLength(4)]
        public string? CodigoISO { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre del Nivel de Precio.")]
        [StringLength(40)]
        public string Nombre { get; set; }

        public int? CtrCtaVentasId { get; set; }

        public int? CtrCtaDescGralId { get; set; }

        public int? CtrCtaCostoVenId { get; set; }

        public int? CtrCtaDescLinId { get; set; }

        public int? CtrCtaCostoLinId { get; set; }

        public int? CtrCtaGasComId { get; set; }

        public int? CtrCtaContadoId { get; set; }

        public int? CtrCtaCCId { get; set; }

        public int? CtrCtaLCId { get; set; }

        public int? CtrCtaProntoPagoCCId { get; set; }

        public int? CtrCtaIntMoraCCId { get; set; }

        public int? CtrCtaRecibosCCId { get; set; }

        public int? CtrCtaDebitoCCId { get; set; }

        public int? CtrCtaCreditoCCId { get; set; }

        public int? CtrCtaImpuesto1CCId { get; set; }

        public int? CtrCtaImpuesto2CCId { get; set; }

        public int? CtrCtaRubro1CCId { get; set; }

        public int? CtrCtaRubro2CCId { get; set; }

        public int? CtrCtaAnticipoCCId { get; set; }

        public int? CtrCtaLPId { get; set; }

        public int? CtrCtaCreditoCPId { get; set; }

        public int? CtrCtaDebitoCPId { get; set; }

        public int? CtrCtaCPId { get; set; }

        public int? CtrCtaProntoPagoCPId { get; set; }

        public int? CtrCtaComisionCPId { get; set; }

        public int? CtrCtaImpuesto1CPId { get; set; }

        public int? CtrCtaImpuesto2CPId { get; set; }

        public int? CtrCtaRubro1CPId { get; set; }

        public int? CtrCtaRubro2CPId { get; set; }

        public int? CtrCtaAnticipoCPId { get; set; }

        public int? CtrCtaDescBonifId { get; set; }

        public int? CtrCtaDevVentasId { get; set; }

        public int? CtrCtaIntCorrienteId { get; set; }

        public int? CtrCtaVentasExenId { get; set; }

        public int? CtrCtaAjusteRedondeoId { get; set; }

        public int? CtrCtaRentaCPId { get; set; }

        [StringLength(20)]
        public string? EtiquetaDivGeo1 { get; set; }

        [StringLength(20)]
        public string? EtiquetaDivGeo2 { get; set; }
    }
}
