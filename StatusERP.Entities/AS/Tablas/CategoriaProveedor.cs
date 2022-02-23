using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class CategoriaProveedor:EntityBase
    {
        [Required]
        [StringLength(8)]
        public string CodCategoriaProveedor { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [StringLength(25)]
        public string ? CtrCP { get; set; }

        [StringLength(25)]
        public string ? CtaCP { get; set; }

        [StringLength(25)]
        public string ? CtrLP { get; set; }

        [StringLength(25)]
        public string? CtaLP { get; set; }

        [StringLength(25)]
        public string ? CtrCreditoCP { get; set; }

        [StringLength(25)]
        public string ? CtaCreditoCP { get; set; }

        [StringLength(25)]
        public string ? CtrDebitoCP { get; set; }

        [StringLength(25)]
        public string ? CtaDebitoCP { get; set; }

        [StringLength(25)]
        public string ? CtrProntoPagoCP { get; set; }

        [StringLength(25)]
        public string ? CtaProntoPagoCP { get; set; }

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
        public string ? CtrAjusteRedondeo { get; set; }

        [StringLength(25)]
        public string ? CtaAjusteRedondeo { get; set; }
    }
}
