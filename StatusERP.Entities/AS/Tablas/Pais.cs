using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Paises", Schema = Constants.Conjunto)]
    public class Pais:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código del País.")]
        [StringLength(4)]
        public string CodPais { get; set; }

        [StringLength(4)]
        public string ? CodigoISO { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre del Nivel de Precio.")]
        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(25)]
        public string ? CtrVentas { get; set; }

        [StringLength(25)]
        public string ? CtaVentas { get; set; }

        [StringLength(25)]
        public string ? CtrDescGral { get; set; }

        [StringLength(25)]
        public string ? CtaDescGral { get; set; }

        [StringLength(25)]
        public string ? CtrCostoVen { get; set; }

        [StringLength(25)]
        public string ? CtaCostoVen { get; set; }

        [StringLength(25)]
        public string ? CtrDescLin { get; set; }

        [StringLength(25)]
        public string ? CtaDescLin { get; set; }

        [StringLength(25)]
        public string ? CtrCostoLin { get; set; }

        [StringLength(25)]
        public string ? CtaCostoLin { get; set; }

        [StringLength(25)]
        public string ? CtrGasCom { get; set; }

        [StringLength(25)]
        public string ? CtaGasCom { get; set; }

        [StringLength(25)]
        public string ? CtrContado { get; set; }

        [StringLength(25)]
        public string ? CtaContado { get; set; }

        [StringLength(25)]
        public string ? CtrCC { get; set; }

        [StringLength(25)]
        public string ? CtaCC { get; set; }

        [StringLength(25)]
        public string ? CtrLC { get; set; }

        [StringLength(25)]
        public string ? CtaLC { get; set; }

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
        public string ? CtaRubro2CC { get; set; }

        [StringLength(25)]
        public string ? CtrAnticipoCC { get; set; }

        [StringLength(25)]
        public string ? CtaAnticipoCC { get; set; }

        [StringLength(25)]
        public string ? CtrLP { get; set; }

        [StringLength(25)]
        public string ? CtaLP { get; set; }

        [StringLength(25)]
        public string ? CtrCreditoCP { get; set; }

        [StringLength(25)]
        public string ? CtaCreditoCP { get; set; }

        [StringLength(25)]
        public string ? CtrDebitoCP { get; set; }

        [StringLength(25)]
        public string ? CtaDebitoCP { get; set; }

        [StringLength(25)]
        public string ? CtrCP { get; set; }

        [StringLength(25)]
        public string ? CtaCP { get; set; }

        [StringLength(25)]
        public string ? CtrProntoPagoCP { get; set; }

        [StringLength(25)]
        public string ? CtaProntoPagoCP { get; set; }

        [StringLength(25)]
        public string ? CtrComisionCP { get; set; }

        [StringLength(25)]
        public string ? CtaComisionCP { get; set; }

        [StringLength(25)]
        public string ? CtrImpuesto1CP { get; set; }

        [StringLength(25)]
        public string ? CtaImpuesto1CP { get; set; }

        [StringLength(25)]
        public string ? CtrImpuesto2CP { get; set; }

        [StringLength(25)]
        public string ? CtaImpuesto2CP { get; set; }

        [StringLength(25)]
        public string ? CtrRubro1CP { get; set; }

        [StringLength(25)]
        public string ? CtaRubro1CP { get; set; }
        [StringLength(25)]
        public string ? CtrRubro2CP { get; set; }

        [StringLength(25)]
        public string ? CtaRubro2CP { get; set; }

        [StringLength(25)]
        public string ? CtrAnticipoCP { get; set; }

        [StringLength(25)]
        public string ? CtaAnticipoCP { get; set; }
        [StringLength(25)]
        public string ? CtrDescBonif { get; set; }

        [StringLength(25)]
        public string ? CtaDescBonif { get; set; }
        [StringLength(25)]
        public string ? CtrDevVentas { get; set; }

        [StringLength(25)]
        public string ? CtaDevVentas { get; set; }
        [StringLength(25)]
        public string ? CtrIntCorriente { get; set; }

        [StringLength(25)]
        public string ? CtaIntCorriente { get; set; }
        [StringLength(25)]
        public string ? CtrVentasExen { get; set; }

        [StringLength(25)]
        public string ? CtaVentasExen { get; set; }
        [StringLength(25)]
        public string ? CtrAjusteRedondeo { get; set; }

        [StringLength(25)]
        public string ? CtaAjusteRedondeo { get; set; }
        [StringLength(25)]
        public string ? CtrRentaCP { get; set; }

        [StringLength(25)]
        public string ? CtaRentaCP { get; set; }

        [StringLength(20)]
        public string ? EtiquetaDivGeo1 { get; set; }

        [StringLength(20)]
        public string ? EtiquetaDivGeo2 { get; set; }
    }
}
