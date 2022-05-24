using StatusERP.Entities.CG.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("CategoriasClientes", Schema = Constants.Conjunto)]
    public class CategoriaCliente:EntityBase
    {
        [Required]
        [StringLength(8)]
        public string CodCategoriaCliente { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public int? CtrCtaVentasId { get; set; }
        [ForeignKey(nameof(CtrCtaVentasId))]
        public CentroCuenta CCVentas { get; set; }

        public int? CtrCtaDescGralId { get; set; }
        [ForeignKey(nameof(CtrCtaDescGralId))]
        public CentroCuenta CCDescGral { get; set; }

        public int? CtrCtaCostVentId { get; set; }
        [ForeignKey(nameof(CtrCtaCostVentId))]
        public CentroCuenta CostVent { get; set; }

        public int? CtrCtaDescLinId { get; set; }
        [ForeignKey(nameof(CtrCtaDescLinId))]
        public CentroCuenta DescLin { get; set; }

        public int? CtrCtaCostLinId { get; set; }
        [ForeignKey(nameof(CtrCtaCostLinId))]
        public CentroCuenta CostLin { get; set; }

        public int? CtrCtaVendComId { get; set; }
        [ForeignKey(nameof(CtrCtaVendComId))]
        public CentroCuenta VendCom { get; set; }

        public int? CtrCtaCobrComId { get; set; }
        [ForeignKey(nameof(CtrCtaCobrComId))]
        public CentroCuenta CobrCom { get; set; }

        public int? CtrCtaCCId { get; set; }
        [ForeignKey(nameof(CtrCtaCCId))]
        public CentroCuenta CC { get; set; }

        public int? CtrCtaLCId { get; set; }
        [ForeignKey(nameof(CtrCtaLCId))]
        public CentroCuenta LC { get; set; }

        public int? CtrCtaContadoId { get; set; }
        [ForeignKey(nameof(CtrCtaContadoId))]
        public CentroCuenta Contado { get; set; }

        public int? CtrCtaProntoPagoCCId { get; set; }
        [ForeignKey(nameof(CtrCtaProntoPagoCCId))]
        public CentroCuenta ProntoPagoCC { get; set; }

        public int? CtrCtaIntMoraCCId { get; set; }
        [ForeignKey(nameof(CtrCtaIntMoraCCId))]
        public CentroCuenta IntMoraCC { get; set; }

        public int? CtrCtaRecibosCCId { get; set; }
        [ForeignKey(nameof(CtrCtaRecibosCCId))]
        public CentroCuenta RecibosCC { get; set; }

        public int? CtrCtaDebitoCCId { get; set; }
        [ForeignKey(nameof(CtrCtaDebitoCCId))]
        public CentroCuenta DebitoCC { get; set; }

        public int? CtrCtaCreditoCCId { get; set; }
        [ForeignKey(nameof(CtrCtaCreditoCCId))]
        public CentroCuenta CreditoCC { get; set; }

        public int? CtrCtaImpuesto1CCId { get; set; }
        [ForeignKey(nameof(CtrCtaImpuesto1CCId))]
        public CentroCuenta Impuesto1CC { get; set; }

        public int? CtrCtaImpuesto2CCId { get; set; }
        [ForeignKey(nameof(CtrCtaImpuesto2CCId))]
        public CentroCuenta Impuesto2CC { get; set; }

        public int? CtrCtaRubro1CCId { get; set; }
        [ForeignKey(nameof(CtrCtaRubro1CCId))]
        public CentroCuenta Rubro1CC { get; set; }

        public int? CtrCtaRubro2CCId { get; set; }
        [ForeignKey(nameof(CtrCtaRubro2CCId))]
        public CentroCuenta Rubro2CC { get; set; }

        public int? CtrCtaAnticipoCCId { get; set; }
        [ForeignKey(nameof(CtrCtaAnticipoCCId))]
        public CentroCuenta AnticipoCC { get; set; }

        public int? CtrCtaDescBonifId { get; set; }
        [ForeignKey(nameof(CtrCtaDescBonifId))]
        public CentroCuenta DescBonif { get; set; }

        public int? CtrCtaDevVentasId { get; set; }
        [ForeignKey(nameof(CtrCtaDevVentasId))]
        public CentroCuenta DevVentas { get; set; }

        public int? CtrCtaIntCorrId { get; set; }
        [ForeignKey(nameof(CtrCtaIntCorrId))]
        public CentroCuenta IntCorr { get; set; }

        public int? CtrCtaVentasExenId { get; set; }
        [ForeignKey(nameof(CtrCtaVentasExenId))]
        public CentroCuenta VentasExen { get; set; }

        public int? CtrCtaAjusteRedondeoId { get; set; }
        [ForeignKey(nameof(CtrCtaAjusteRedondeoId))]
        public CentroCuenta AjusteRedondeo { get; set; }
    }
}
