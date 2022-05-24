using StatusERP.Entities.CG.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("CategoriasProveedor", Schema = Constants.Conjunto)]
    public class CategoriaProveedor:EntityBase
    {
        [Required]
        [StringLength(8)]
        public string CodCategoriaProveedor { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public int? CtrCtaCPId { get; set; }
        [ForeignKey(nameof(CtrCtaCPId))]
        public CentroCuenta CP { get; set; }

        public int? CtrCtaLPId { get; set; }
        [ForeignKey(nameof(CtrCtaLPId))]
        public CentroCuenta LP { get; set; }

        public int? CtrCtaCreditoCPId { get; set; }
        [ForeignKey(nameof(CtrCtaCreditoCPId))]
        public CentroCuenta CreditoCP { get; set; }

        public int? CtrCtaDebitoCPId { get; set; }
        [ForeignKey(nameof(CtrCtaDebitoCPId))]
        public CentroCuenta DebitoCP { get; set; }

        public int? CtrCtaProntoPagoCPId { get; set; }
        [ForeignKey(nameof(CtrCtaProntoPagoCPId))]
        public CentroCuenta ProntoPagoCP { get; set; }

        public int? CtrCtaImpuesto1CPId { get; set; }
        [ForeignKey(nameof(CtrCtaImpuesto1CPId))]
        public CentroCuenta Impuesto1CP { get; set; }

        public int? CtrCtaImpuesto2CPId { get; set; }
        [ForeignKey(nameof(CtrCtaImpuesto2CPId))]
        public CentroCuenta Impuesto2CP { get; set; }

        public int? CtrCtaRubro1CPId { get; set; }
        [ForeignKey(nameof(CtrCtaRubro1CPId))]
        public CentroCuenta Rubro1CP { get; set; }

        public int? CtrCtaRubro2CPId { get; set; }
        [ForeignKey(nameof(CtrCtaRubro2CPId))]
        public CentroCuenta Rubro2CP { get; set; }

        public int? CtrCtaAnticipoCPId { get; set; }
        [ForeignKey(nameof(CtrCtaAnticipoCPId))]
        public CentroCuenta AnticipoCP { get; set; }

        public int? CtrCtaAjusteRedondeoId { get; set; }
        [ForeignKey(nameof(CtrCtaAjusteRedondeoId))]
        public CentroCuenta AjusteRedondeo { get; set; }
    }
}
