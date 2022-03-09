using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string Descripción { get; set; }
        
        [StringLength(25)]
        public string ? CtrInventario { get; set; }
        
        [StringLength(25)]
        public string ? CtaInventario { get; set; }
        
        [StringLength(25)]
        public string ? CtrVentasLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtaVentasLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtrVentasExp { get; set; }
        
        [StringLength(25)]
        public string ? CtaVentasExp { get; set; }
        
        [StringLength(25)]
        public string ? CtrCompraLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtaCompraLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtrCompraImp { get; set; }

        [StringLength(25)]
        public string ? CtaCompraImp { get; set; }
        
        [StringLength(25)]
        public string ? CtrDescVentaLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtaDescVentaLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtrDescVentaExp { get; set; }
        
        [StringLength(25)]
        public string ? CtaDescVentaExp { get; set; }
        
        [StringLength(25)]
        public string ? CtrCostVentaLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtaCostVentaLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtrCostVentaExp { get; set; }
        
        [StringLength(25)]
        public string ? CtrComsVentaLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtaComsVentaLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtrComsVentaExp { get; set; }
        
        [StringLength(25)]
        public string ? CtaComsVentaExp { get; set; }
        
        [StringLength(25)]
        public string ? CtrComsCobroLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtaComsCobroLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtrComsCobroExp { get; set; }
        
        [StringLength(25)]
        public string ? CtaComsCobroExp { get; set; }
        
        [StringLength(25)]
        public string ? CtrDescLineaLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtaDescLineaLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtrDescLineaExp { get; set; }
        
        [StringLength(25)]
        public string ? CtaDescLineaExp { get; set; }
        
        [StringLength(25)]
        public string ? CtrCostDescLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtaCostDescLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtrCostDescExp { get; set; }
        
        [StringLength(25)]
        public string ? CtaCostDescExp { get; set; }
        
        [StringLength(25)]
        public string ? CtrSobrInventFis { get; set; }
        
        [StringLength(25)]
        public string ? CtaSobrInventFis { get; set; }
        
        [StringLength(25)]
        public string ? CtrFaltInventFis { get; set; }
        
        [StringLength(25)]
        public string ? CtaFaltInventFis { get; set; }
        
        [StringLength(25)]
        public string ? CtrVariaCosto { get; set; }
        
        [StringLength(25)]
        public string ? CtaVariaCosto { get; set; }
        
        [StringLength(25)]
        public string ? CtrVencimiento { get; set; }
        
        [StringLength(25)]
        public string ? CtaVencimiento { get; set; }
        
        [StringLength(25)]
        public string ? CtrSobranteRemis { get; set; }
        
        [StringLength(25)]
        public string ? CtaSobranteRemis { get; set; }
        
        [StringLength(25)]
        public string ? CtrFaltanteRemis { get; set; }
        
        [StringLength(25)]
        public string ? CtaFaltanteRemis { get; set; }
        
        [StringLength(25)]
        public string ? CtrInvRemitido { get; set; }
        
        [StringLength(25)]
        public string ? CtaInvRemitido { get; set; }
        
        [StringLength(25)]
        public string ? CtrMatProceso { get; set; }
        
        [StringLength(25)]
        public string ? CtaMatProceso { get; set; }
        
        [StringLength(25)]
        public string ? CtrConsNormal { get; set; }
        
        [StringLength(25)]
        public string ? CtaConsNormal { get; set; }
        
        [StringLength(25)]
        public string ? CtrConsRetrabajo { get; set; }
        
        [StringLength(25)]
        public string ? CtaConsRetrabajo { get; set; }
        
        [StringLength(25)]
        public string ? CtrConsGasto { get; set; }
        
        [StringLength(25)]
        public string ? CtaConsGasto { get; set; }
        
        [StringLength(25)]
        public string ? CtrConsDesperdic { get; set; }
        
        [StringLength(25)]
        public string ? CtaConsDesperdic { get; set; }
        
        [StringLength(25)]
        public string ? CtrDescBonifLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtaDescBonifLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtrDescBonifExp { get; set; }
        
        [StringLength(25)]
        public string ? CtaDescBonifExp { get; set; }
        
        [StringLength(25)]
        public string ? CtrDevVentasLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtaDevVentasLoc { get; set; }
        
        [StringLength(25)]
        public string ? CtrDevVentasExp { get; set; }
        
        [StringLength(25)]
        public string ? CtaDevVentasExp { get; set; }
        
        [StringLength(25)]
        public string ? CtrCtoRetAsum{ get; set; }
        
        [StringLength(25)]
        public string ? CtaCtbRetAsum{ get; set; }
        
        [StringLength(25)]
        public string ? CtrCtoAju{ get; set; }
        
        [StringLength(25)]
        public string ? CtaCtbAju { get; set; }
        
        [StringLength(25)]
        public string ? CtrCtoAjuCMV { get; set; }
        
        [StringLength(25)]
        public string ? CtaCtbAjuCMV { get; set; }
        
        [StringLength(25)]
        public string ? CtrCtoCPGar { get; set; }
        
        [StringLength(25)]
        public string ? CtaCtbCPGar { get; set; }
        
        [StringLength(25)]
        public string ? CtrCtoPuGar { get; set; }
        
        [StringLength(25)]
        public string ? CtaCtbPuGar { get; set; }
        
        [StringLength(25)]
        public string ? CtrCtoIngDevoluc { get; set; }
        
        [StringLength(25)]
        public string ? CtaCtbIngDevoluc { get; set; }
        
        [StringLength(25)]
        public string ? CtrCtoPerdDevoluc{ get; set; }
        
        [StringLength(25)]
        public string ? CtaCtbPerdDevoluc{ get; set; }
        
        [StringLength(25)]
        public string ? CtrCtoMatAplicados{ get; set; }
        
        [StringLength(25)]
        public string ? CtaCtbMatAplicados{ get; set; }
        
        [StringLength(25)]
        public string ? CtrVentasExenLoc{ get; set; }
        
        [StringLength(25)]
        public string ? CtaVentasExenLoc{ get; set; }
        
        [StringLength(25)]
        public string ? CtrVentasExenExp{ get; set; }
        
        [StringLength(25)]
        public string ? CtaVentasExenExp{ get; set; }
    }
}
