using StatusERP.Entities.CG.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Paises", Schema = Constants.Conjunto)]
    public class Pais:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodPais { get; set; }

        [StringLength(4)]
        public string ? CodigoISO { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        public int? CtrCtaVentasId { get; set; }
        [ForeignKey(nameof(CtrCtaVentasId))]
        public CentroCuenta CCVentas { get; set; }

        public int? CtrCtaDescGralId { get; set; }
        [ForeignKey(nameof(CtrCtaDescGralId))]
        public CentroCuenta CCDescGral { get; set; }

        public int? CtrCtaCostoVenId { get; set; }
        [ForeignKey(nameof(CtrCtaCostoVenId))]
        public CentroCuenta CCCostoVen { get; set; }

        public int? CtrCtaDescLinId { get; set; }
        [ForeignKey(nameof(CtrCtaDescLinId))]
        public CentroCuenta CCDescLin { get; set; }

        public int? CtrCtaCostoLinId { get; set; }
        [ForeignKey(nameof(CtrCtaCostoLinId))]
        public CentroCuenta CCCostoLin { get; set; }

        public int? CtrCtaGasComId { get; set; }
        [ForeignKey(nameof(CtrCtaGasComId))]
        public CentroCuenta CCGasCom { get; set; }

        public int? CtrCtaContadoId { get; set; }
        [ForeignKey(nameof(CtrCtaContadoId))]
        public CentroCuenta CCContado { get; set; }

        public int? CtrCtaCCId { get; set; }
        [ForeignKey(nameof(CtrCtaCCId))]
        public CentroCuenta CCCC { get; set; }

        public int? CtrCtaLCId { get; set; }
        [ForeignKey(nameof(CtrCtaLCId))]
        public CentroCuenta CCLC { get; set; }

        public int? CtrCtaProntoPagoCCId { get; set; }
        [ForeignKey(nameof(CtrCtaProntoPagoCCId))]
        public CentroCuenta CCProntoPagoCC { get; set; }

        public int? CtrCtaIntMoraCCId { get; set; }
        [ForeignKey(nameof(CtrCtaIntMoraCCId))]
        public CentroCuenta CCIntMoraCC { get; set; }

        public int? CtrCtaRecibosCCId { get; set; }
        [ForeignKey(nameof(CtrCtaRecibosCCId))]
        public CentroCuenta CCRecibosCC { get; set; }

        public int? CtrCtaDebitoCCId { get; set; }
        [ForeignKey(nameof(CtrCtaDebitoCCId))]
        public CentroCuenta CCDebitoCC { get; set; }

        public int? CtrCtaCreditoCCId { get; set; }
        [ForeignKey(nameof(CtrCtaCreditoCCId))]
        public CentroCuenta CCCreditoCC { get; set; }

        public int? CtrCtaImpuesto1CCId { get; set; }
        [ForeignKey(nameof(CtrCtaImpuesto1CCId))]
        public CentroCuenta CCImpuesto1CC { get; set; }

        public int? CtrCtaImpuesto2CCId { get; set; }
        [ForeignKey(nameof(CtrCtaImpuesto2CCId))]
        public CentroCuenta CCImpuesto2CC { get; set; }

        public int? CtrCtaRubro1CCId { get; set; }
        [ForeignKey(nameof(CtrCtaRubro1CCId))]
        public CentroCuenta CCRubro1CC { get; set; }

        public int? CtrCtaRubro2CCId { get; set; }
        [ForeignKey(nameof(CtrCtaRubro2CCId))]
        public CentroCuenta CCRubro2CC { get; set; }

        public int? CtrCtaAnticipoCCId { get; set; }
        [ForeignKey(nameof(CtrCtaAnticipoCCId))]
        public CentroCuenta CCAnticipoCC { get; set; }

        public int? CtrCtaLPId { get; set; }
        [ForeignKey(nameof(CtrCtaLPId))]
        public CentroCuenta CCLP { get; set; }

        public int? CtrCtaCreditoCPId { get; set; }
        [ForeignKey(nameof(CtrCtaCreditoCPId))]
        public CentroCuenta CCCreditoCP { get; set; }

        public int? CtrCtaDebitoCPId { get; set; }
        [ForeignKey(nameof(CtrCtaDebitoCPId))]
        public CentroCuenta CCDebitoCP { get; set; }

        public int? CtrCtaCPId { get; set; }
        [ForeignKey(nameof(CtrCtaCPId))]
        public CentroCuenta CCCP { get; set; }

        public int? CtrCtaProntoPagoCPId { get; set; }
        [ForeignKey(nameof(CtrCtaProntoPagoCPId))]
        public CentroCuenta CCProntoPagoCP { get; set; }

        public int? CtrCtaComisionCPId { get; set; }
        [ForeignKey(nameof(CtrCtaComisionCPId))]
        public CentroCuenta CCComisionCP { get; set; }

        public int? CtrCtaImpuesto1CPId { get; set; }
        [ForeignKey(nameof(CtrCtaImpuesto1CPId))]
        public CentroCuenta CCImpuesto1CP { get; set; }

        public int? CtrCtaImpuesto2CPId { get; set; }
        [ForeignKey(nameof(CtrCtaImpuesto2CPId))]
        public CentroCuenta CCImpuesto2CP { get; set; }

        public int? CtrCtaRubro1CPId { get; set; }
        [ForeignKey(nameof(CtrCtaRubro1CPId))]
        public CentroCuenta CCRubro1CP { get; set; }

        public int? CtrCtaRubro2CPId { get; set; }
        [ForeignKey(nameof(CtrCtaRubro2CPId))]
        public CentroCuenta CCRubro2CP { get; set; }

        public int? CtrCtaAnticipoCPId { get; set; }
        [ForeignKey(nameof(CtrCtaAnticipoCPId))]
        public CentroCuenta CCAnticipoCP { get; set; }

        public int? CtrCtaDescBonifId { get; set; }
        [ForeignKey(nameof(CtrCtaDescBonifId))]
        public CentroCuenta CCDescBonif { get; set; }

        public int? CtrCtaDevVentasId { get; set; }
        [ForeignKey(nameof(CtrCtaDevVentasId))]
        public CentroCuenta CCDevVentas { get; set; }

        public int? CtrCtaIntCorrienteId { get; set; }
        [ForeignKey(nameof(CtrCtaIntCorrienteId))]
        public CentroCuenta CCIntCorriente { get; set; }

        public int? CtrCtaVentasExenId { get; set; }
        [ForeignKey(nameof(CtrCtaVentasExenId))]
        public CentroCuenta CCVentasExen { get; set; }

        public int? CtrCtaAjusteRedondeoId { get; set; }
        [ForeignKey(nameof(CtrCtaAjusteRedondeoId))]
        public CentroCuenta CCAjusteRedondeo { get; set; }

        public int? CtrCtaRentaCPId { get; set; }
        [ForeignKey(nameof(CtrCtaRentaCPId))]
        public CentroCuenta CCRentaCP { get; set; }

        public int? CtrCtaPensionONPCPId { get; set; }
        [ForeignKey(nameof(CtrCtaPensionONPCPId))]
        public CentroCuenta CCPensionONPCP { get; set; }

        public int? CtrCtaPensionAFPCPId { get; set; }
        [ForeignKey(nameof(CtrCtaPensionAFPCPId))]
        public CentroCuenta CCPensionAFPCP { get; set; }

        public int? CtrCtaComisionId { get; set; }
        [ForeignKey(nameof(CtrCtaComisionId))]
        public CentroCuenta CCComision { get; set; }

        public int? CtrCtaAdValoremId { get; set; }
        [ForeignKey(nameof(CtrCtaAdValoremId))]
        public CentroCuenta CCAdValorem { get; set; }

        public int? DireccionId { get; set; }
        [ForeignKey(nameof(DireccionId))]
        public Direccion Direccion { get; set; }

        [StringLength(20)]
        public string ? EtiquetaDivGeo1 { get; set; }

        [StringLength(20)]
        public string ? EtiquetaDivGeo2 { get; set; }

        public int? MonedaId { get; set; }
        [ForeignKey(nameof(MonedaId))]
        public Moneda Moneda { get; set; }
    }
}
