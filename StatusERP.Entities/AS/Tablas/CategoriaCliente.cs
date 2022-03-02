using StatusERP.Entities.CG.Tablas;
using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class CategoriaCliente:EntityBase
    {
        [Required(ErrorMessage = "Se requiere código para la Categoría de Cliente")]
        [StringLength(8)]
        public string CodCategoriaCliente { get; set; }

        [Required(ErrorMessage = "Se requiere especificar Descripción de la Categoría de Cliente")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [StringLength(25)]
        public string ? CtrVentas { get; set; }
        public virtual CentroCosto CentroCosto { get; set; }

        [StringLength(25)]
        public string ? CtaVentas { get; set; }
        public virtual CuentaContable CuentaContable { get; set; }

        [StringLength(25)]
        public string ? CtrDescGral { get; set; }
   
        [StringLength(25)]
        public string ? CtaDescGral { get; set; }
 
        [StringLength(25)]
        public string ? CtrCostVent { get; set; }

        [StringLength(25)]
        public string ? CtaCostVent { get; set; }

        [StringLength(25)]
        public string ? CtrDescLin { get; set; }

        [StringLength(25)]
        public string ? CtaDescLin { get; set; }

        [StringLength(25)]
        public string ? CtrCostLin { get; set; }

        [StringLength(25)]
        public string ? CtaCostLin { get; set; }

        [StringLength(25)]
        public string? CtrVendCom { get; set; }

        [StringLength(25)]
        public string ? CtaVendCom { get; set; }

        [StringLength(25)]
        public string ? CtrCobrCom { get; set; }

        [StringLength(25)]
        public string ? CtaCobrCom { get; set; }

        [StringLength(25)]
        public string ? CtrCC { get; set; }

        [StringLength(25)]
        public string ? CtaCC { get; set; }

        [StringLength(25)]
        public string ? CtrLC { get; set; }

        [StringLength(25)]
        public string ? CtaLC { get; set; }

        [StringLength(25)]
        public string ? CtrContado { get; set; }

        [StringLength(25)]
        public string ? CtaContado { get; set; }

        [StringLength(25)]
        public string ? CtrProntoPagoCC { get; set; }

        [StringLength(25)]
        public string ? CtaProntoPagoCC { get; set; }

        [StringLength(25)]
        public string ? CtrIntMoraCC { get; set; }

        [StringLength(25)]
        public string ? CtaIntMoraCC { get; set; }

        [StringLength(25)]
        public string ? CtrRecibosCC { get; set; }

        [StringLength(25)]
        public string ? CtaRecibosCC { get; set; }

        [StringLength(25)]
        public string ? CtrDebitoCC { get; set; }

        [StringLength(25)]
        public string ? CtaDebitoCC { get; set; }

        [StringLength(25)]
        public string ? CtrCreditoCC { get; set; }

        [StringLength(25)]
        public string ? CtaCreditoCC { get; set; }

        [StringLength(25)]
        public string ? CtrImpuesto1CC { get; set; }

        [StringLength(25)]
        public string ? CtaImpuesto1CC { get; set; }

        [StringLength(25)]
        public string ? CtrImpuesto2CC { get; set; }

        [StringLength(25)]
        public string ? CtaImpuesto2CC { get; set; }

        [StringLength(25)]
        public string ? CtrRubro1CC { get; set; }

        [StringLength(25)]
        public string ? CtaRubro1CC { get; set; }

        [StringLength(25)]
        public string ? CtrRubro2CC { get; set; }

        [StringLength(25)]
        public string? CtaRubro2CC { get; set; }

        [StringLength(25)]
        public string ? CtrAnticipoCC { get; set; }

        [StringLength(25)]
        public string ? CtaAnticipoCC { get; set; }

        [StringLength(25)]
        public string ? CtrDescBonif { get; set; }
 
        [StringLength(25)]
        public string ? CtaDescBonif { get; set; }

        [StringLength(25)]
        public string ? CtrDevVentas { get; set; }

        [StringLength(25)]
        public string ? CtaDevVentas { get; set; }

        [StringLength(25)]
        public string ? CtrIntCorr { get; set; }

        [StringLength(25)]
        public string ? CtaIntCorr { get; set; }

        [StringLength(25)]
        public string ? CtrVentasExen { get; set; }

        [StringLength(25)]
        public string ? CtaVentasExen { get; set; }

        [StringLength(25)]
        public string ? CtrAjusteRedondeo { get; set; }

        [StringLength(25)]
        public string ? CtaAjusteRedondeo { get; set; }
    }
}
