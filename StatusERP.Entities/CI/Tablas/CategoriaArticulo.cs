using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Entities.CI.Tablas
{
    [Table("CategoriasArticulos", Schema = Constants.Conjunto)]
    public class CategoriaArticulo:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar un código para la Categoría de Artículo")]
        [StringLength(4)]
        public string CodCategoriaArticulo { get; set; }
        
        [Required(ErrorMessage = "Se requiere especificar la descripción para la Categoría de Artículo")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        
        public int? CtrCtaInventarioId { get; set; }
        public CentroCuenta CCInventario { get; set; }

        public int? CtrCtaVentasLocId { get; set; }
        public CentroCuenta CCVentasLoc { get; set; }

        public int? CtrCtaVentasExpId { get; set; }
        public CentroCuenta CCVentasExp { get; set; }

        public int? CtrCtaCompraLocId { get; set; }
        public CentroCuenta CCCompraLoc { get; set; }

        public int? CtrCtaCompraImpId { get; set; }
        public CentroCuenta CCCompraImp { get; set; }

        public int? CtrCtaDescVentaLocId { get; set; }
        public CentroCuenta CCDescVentaLoc { get; set; }

        public int? CtrCtaDescVentaExpId { get; set; }
        public CentroCuenta CCDescVentaExp { get; set; }

        public int? CtrCtaCostVentaLocId { get; set; }
        public CentroCuenta CCCostVentaLoc { get; set; }

        public int? CtrCtaCostVentaExpId { get; set; }
        public CentroCuenta CCCostVentaExp { get; set; }

        public int? CtrCtaComsVentaLocId { get; set; }
        public CentroCuenta CCComsVentaLoc { get; set; }

        public int? CtrCtaComsVentaExpId { get; set; }
        public CentroCuenta CCComsVentaExp { get; set; }

        public int? CtrCtaComsCobroLocId { get; set; }
        public CentroCuenta CCComsCobroLoc { get; set; }

        public int? CtrCtaComsCobroExpId { get; set; }
        public CentroCuenta CCComsCobroExp { get; set; }

        public int? CtrCtaDescLineaLocId { get; set; }
        public CentroCuenta CCDescLineaLoc { get; set; }

        public int? CtrCtaDescLineaExpId { get; set; }
        public CentroCuenta CCDescLineaExp { get; set; }

        public int? CtrCtaCostDescLocId { get; set; }
        public CentroCuenta CCCostoDescLoc { get; set; }

        public int? CtrCtaCostDescExpId { get; set; }
        public CentroCuenta CCCostDescExp { get; set; }

        public int ? CtrCtaSobrInventFisId { get; set; }
        public CentroCuenta CCSobrInventFis { get; set; }

        public int? CtrCtaFaltInventFisId { get; set; }
        public CentroCuenta CCFaltInventFis { get; set; }

        public int? CtrCtaVariaCostoId { get; set; }
        public CentroCuenta CCVariaCosto { get; set; }

        public int? CtrCtaVencimientoId { get; set; }
        public CentroCuenta CCVencimiento { get; set; }

        public int? CtrCtaSobranteRemisId { get; set; }
        public CentroCuenta CCSobranteRemis { get; set; }

        public int? CtrCtaFaltanteRemisId { get; set; }
        public CentroCuenta CCFaltanteRemis { get; set; }

        public int? CtrCtaInvRemitidoId { get; set; }
        public CentroCuenta CCInvRemitido { get; set; }

        public int? CtrCtaMatProcesoId { get; set; }
        public CentroCuenta CCMatProceso { get; set; }

        public int? CtrCtaConsNormalId { get; set; }
        public CentroCuenta CCConsNormal { get; set; }

        public int? CtrCtaConsRetrabajoId { get; set; }
        public CentroCuenta CCConsRetrabajo { get; set; }

        public int? CtrCtaConsGastoId { get; set; }
        public CentroCuenta CCConsGasto { get; set; }

        public int? CtrCtaConsDesperdicId { get; set; }
        public CentroCuenta CCConsDesperdic { get; set; }

        public int? CtrCtaDescBonifLocId { get; set; }
        public CentroCuenta CCDescBonifLoc { get; set; }

        public int? CtrCtaDescBonifExpId { get; set; }
        public CentroCuenta CCDescBonifExp { get; set; }

        public int? CtrCtaDevVentasLocId { get; set; }
        public CentroCuenta CCDevVentasLoc { get; set; }

        public int? CtrCtaDevVentasExpId { get; set; }
        public CentroCuenta CCDevVentasExp { get; set; }

        public int? CtrCtaRetAsumId { get; set; }
        public CentroCuenta CCRetAsum { get; set; }

        public int? CtrCtaAjuId { get; set; }
        public CentroCuenta CCAju { get; set; }

        public int? CtrCtaAjuCMVId { get; set; }
        public CentroCuenta CCAjuCMV { get; set; }

        public int? CtrCtaCPGarId { get; set; }
        public CentroCuenta CCCPGar { get; set; }

        public int? CtrCtaPuGarId { get; set; }
        public CentroCuenta CCPuGar { get; set; }

        public int? CtrCtaIngDevolucId { get; set; }
        public CentroCuenta CCIngDevoluc { get; set; }

        public int? CtrCtaPerdDevolucId { get; set; }
        public CentroCuenta CCPerdDevoluc { get; set; }

        public int? CtrCtaMatAplicadosId { get; set; }
        public CentroCuenta CCMatAplicados { get; set; }

        public int? CtrCtaVentasExenLocId { get; set; }
        public CentroCuenta CCVentasExenLoc { get; set; }

        public int? CtrCtaVentasExenExpId { get; set; }
        public CentroCuenta CCVentasExenExp { get; set; }
    }
}
