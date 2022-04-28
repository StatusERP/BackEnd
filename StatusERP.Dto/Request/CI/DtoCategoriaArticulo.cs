using System.ComponentModel.DataAnnotations;


namespace StatusERP.Dto.Request.CI
{
    public class DtoCategoriaArticulo
    {
        [Required(ErrorMessage = "Se requiere especificar un código para la Categoría de Artículo")]
        [StringLength(4)]
        public string CodCategoriaArticulo { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la descripción para la Categoría de Artículo")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public int ? CtrCtaInventarioId { get; set; }
        
        public int ? CtrCtaVentasLocId { get; set; }

        public int ? CtrCtaVentasExpId { get; set; }

        public int ? CtrCtaCompraLocId { get; set; }

        public int ? CtrCtaCompraImpId { get; set; }

        public int ? CtrCtaDescVentaLocId { get; set; }

        public int ? CtrCtaDescVentaExpId { get; set; }

        public int ? CtrCtaCostVentaLocId { get; set; }

        public int ? CtrCtaCostVentaExpId { get; set; }

        public int ? CtrCtaComsVentaLocId { get; set; }

        public int ? CtrCtaComsVentaExpId { get; set; }

        public int ? CtrCtaComsCobroLocId { get; set; }

        public int ? CtrCtaComsCobroExpId { get; set; }

        public int ? CtrCtaDescLineaLocId { get; set; }

        public int ? CtrCtaDescLineaExpId { get; set; }

        public int ? CtrCtaCostDescLocId { get; set; }

        public int ? CtrCtaCostDescExpId { get; set; }

        public int ? CtrCtaSobrInventFisId { get; set; }

        public int ? CtrCtaFaltInventFisId { get; set; }

        public int ? CtrCtaVariaCostoId { get; set; }

        public int ? CtrCtaVencimientoId { get; set; }

        public int ? CtrCtaSobranteRemisId { get; set; }

        public int ? CtrCtaFaltanteRemisId { get; set; }

        public int ? CtrCtaInvRemitidoId { get; set; }

        public int ? CtrCtaMatProcesoId { get; set; }

        public int ? CtrCtaConsNormalId { get; set; }

        public int ? CtrCtaConsRetrabajoId { get; set; }

        public int ? CtrCtaConsGastoId { get; set; }

        public int ? CtrCtaConsDesperdicId { get; set; }

        public int ? CtrCtaDescBonifLocId { get; set; }

        public int ? CtrCtaDescBonifExpId { get; set; }

        public int ? CtrCtaDevVentasLocId { get; set; }

        public int ? CtrCtaDevVentasExpId { get; set; }

        public int ? CtrCtaRetAsumId { get; set; }

        public int ? CtrCtaAjuId { get; set; }

        public int ? CtrCtaAjuCMVId { get; set; }

        public int ? CtrCtaCPGarId { get; set; }

        public int ? CtrCtaPuGarId { get; set; }

        public int ? CtrCtaIngDevolucId { get; set; }

        public int ? CtrCtaPerdDevolucId { get; set; }

        public int ? CtrCtaMatAplicadosId { get; set; }

        public int ? CtrCtaVentasExenLocId { get; set; }

        public int ? CtrCtaVentasExenExpId { get; set; }
    }
}
