using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoCategoriaProveedor
    {
        [Required(ErrorMessage = "Se requiere indicar código para la Categoría de Proveedor")]
        [StringLength(8)]
        public string CodCategoriaProveedor { get; set; }

        [Required(ErrorMessage = "Se requiere especificar descripción de la Categoría de Proveedor")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public int? CtrCtaCPId { get; set; }

        public int? CtrCtaLPId { get; set; }

        public int? CtrCtaCreditoCPId { get; set; }

        public int? CtrCtaDebitoCPId { get; set; }

        public int? CtrCtaProntoPagoCPId { get; set; }

        public int? CtrCtaImpuesto1CPId { get; set; }

        public int? CtrCtaImpuesto2CPId { get; set; }

        public int? CtrCtaRubro1CPId { get; set; }

        public int? CtrCtaRubro2CPId { get; set; }

        public int? CtrCtaAnticipoCPId { get; set; }

        public int? CtrCtaAjusteRedondeoId { get; set; }
    }
}
