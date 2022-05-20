using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoCategoriaCliente
    {
        [Required(ErrorMessage = "Se requiere código para la Categoría de Cliente")]
        [StringLength(8)]
        public string CodCategoriaCliente { get; set; }

        [Required(ErrorMessage = "Se requiere especificar Descripción de la Categoría de Cliente")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public int? CtrCtaVentasId { get; set; }

        public int? CtrCtaDescGralId { get; set; }

        public int? CtrCtaCostVentId { get; set; }

        public int? CtrCtaDescLinId { get; set; }

        public int? CtrCtaCostLinId { get; set; }

        public int? CtrCtaVendComId { get; set; }

        public int? CtrCtaCobrComId { get; set; }

        public int? CtrCtaCCId { get; set; }

        public int? CtrCtaLCId { get; set; }

        public int? CtrCtaContadoId { get; set; }

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

        public int? CtrCtaDescBonifId { get; set; }

        public int? CtrCtaDevVentasId { get; set; }

        public int? CtrCtaIntCorrId { get; set; }

        public int? CtrCtaVentasExenId { get; set; }

        public int? CtrCtaAjusteRedondeoId { get; set; }
    }
}
