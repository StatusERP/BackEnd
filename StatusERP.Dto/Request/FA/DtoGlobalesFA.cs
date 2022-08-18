using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.FA
{
    public class DtoGlobalesFA
    {
        public int? BodegaDefaultId { get; set; }

        public int? CondPagoContadoId { get; set; }

        public bool VendedorObligator { get; set; }

        public bool FactExcPedido { get; set; }

        public bool UsaTarjetaCred { get; set; }

        public bool BodegaPorLinea { get; set; }

        public bool PermiteBackorder { get; set; }

        public bool CancelPedParcial { get; set; }

        public bool PedAImpresora { get; set; }

        public bool DocAImpresora { get; set; }

        public bool ImpreLoteSeparad { get; set; }

        public bool FacturaMultipag { get; set; }

        public bool NCRNumFactura { get; set; }

        public bool MultipleFMTFactu { get; set; }

        public bool MultipleFMTPedid { get; set; }

        public bool OrdenLineasFact { get; set; }

        public bool ReimpresionPedido { get; set; }

        public bool ImpPedidoAlFact { get; set; }

        public bool RedondearFactura { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal FactorRedondeo { get; set; }

        public Int16 PreciosDec { get; set; }

        public bool DescEnPrecio { get; set; }

        public bool Imp1EnPrecio { get; set; }

        public bool Imp1AfectaDescto { get; set; }

        public bool AplicaNiPrImp1 { get; set; }

        public int? NivelPrecioImp1Id { get; set; }

        public bool PagoComParcial { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PorcImpComision { get; set; }

        public bool AsientoVentaPor { get; set; }

        public int? TipoPartidaId { get; set; }

        public int? PaqueteId { get; set; }

        public int? CtrCtaFleteId { get; set; }

        public int? CtrCtaSeguroId { get; set; }

        public int? CtrCtaDocumentacionId { get; set; }

        public int? CtrCtaImpuesto1Id { get; set; }

        public int? CtrCtaImpuesto2Id { get; set; }

        public int? CtrCtaImpComisioId { get; set; }

        public bool UsarRubros { get; set; }

        [StringLength(15)]
        public string? Rubro1Nombre { get; set; }

        [StringLength(15)]
        public string? Rubro2Nombre { get; set; }

        [StringLength(15)]
        public string? Rubro3Nombre { get; set; }

        [StringLength(15)]
        public string? Rubro4Nombre { get; set; }

        public bool UsaBoletas { get; set; }

        [StringLength(60)]
        public string? NomRubro6Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro7Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro8Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro9Cli { get; set; }

        [StringLength(15)]
        public string? Rubro5Nombre { get; set; }

        public string? Observaciones { get; set; }

        public int? NivelPrecioPublicoId { get; set; }

        public string? ColumnasEstandar { get; set; }

        [StringLength(1)]
        public string AsientoCostoPor { get; set; }

        public bool CambiarEsqTrab { get; set; }

        public bool FactDocsVencidos { get; set; }

        public bool FactCobroJud { get; set; }

        public bool FactLimiteCred { get; set; }

        public Int16 ModAplicAsiento { get; set; }

        public bool IntegracionConta { get; set; }

        [StringLength(1)]
        public string TipoContaOmision { get; set; }

        public int? TipoCambioId { get; set; }

        public bool PrecisionMaxima { get; set; }

        public Int16 LineasArticulo { get; set; }

        public Int16 LineasFactura { get; set; }

        public Int16 LineasAdicionales { get; set; }

        public bool DetalleKits { get; set; }

        [StringLength(1)]
        public string MonedaPrecios { get; set; }

        public bool? Prevista1 { get; set; }

        public bool? Prevista2 { get; set; }

        public bool? Prevista3 { get; set; }

        public bool? Prevista4 { get; set; }

        public bool? Prevista5 { get; set; }

        public int? CtrConsumoId { get; set; }

        public bool CCEnLinea { get; set; }

        public bool CGEnLinea { get; set; }

        public bool UsarAutorizacion { get; set; }

        public bool Imp1EnBonifica { get; set; }

        public bool Imp2EnBonifica { get; set; }

        [StringLength(1)]
        public string AsientoContCXCPor { get; set; }

        public bool UsarAprobPedidos { get; set; }

        [StringLength(60)]
        public string? NomRubro10Cli { get; set; }

        [StringLength(1)]
        public string ListaPrecios { get; set; }

        public bool MargenUtilidad { get; set; }

        public bool MontoMinimo { get; set; }

        public bool DocVencidos { get; set; }

        public bool LimiteCredito { get; set; }

        public bool CobroJudicial { get; set; }

        public bool SinOC { get; set; }

        public bool DiasAtraso { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? MontoMinimoLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? MontoMinimoDolar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? SaldoMaxLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? SaldoMaxDolar { get; set; }

        public Int16? MaxDiasAtraso { get; set; }

        public Int16? MaxDocsVenc { get; set; }

        public Int16 PreciosDecDolar { get; set; }

        public bool CondPagoNivPre { get; set; }

        public bool FactListaPrecios { get; set; }

        public bool FactMargenUtilid { get; set; }

        public bool FactMontoMinimo { get; set; }

        public bool FactDiasAtraso { get; set; }

        public bool FactSinOC { get; set; }

        public bool UsarRubrosVal { get; set; }

        public bool ImpDescClasific { get; set; }

        public bool LimitarMaxLineas { get; set; }

        public bool IndicadPedido { get; set; }

        public bool PrecioCosto { get; set; }

        public bool FactMenorReserva { get; set; }

        public bool AnulaCXCAplicado { get; set; }

        public bool TipoCostoNoExist { get; set; }

        public bool CalculoImp2 { get; set; }

        public int CategoriaClienteId { get; set; }

        public int NivelPrecioId { get; set; }

        public bool DescuentoCascada { get; set; }

        public bool Retenciones { get; set; }

        public bool RetencionesFletes { get; set; }

        public int? ArticuloId { get; set; }

        [StringLength(4)]
        public string? CodigoRetencion { get; set; }

        public bool AplicarDescGen { get; set; }

        [StringLength(1)]
        public string ModoDescMult { get; set; }

        public bool DctoGeneral { get; set; }

        public bool FactDctoGeneral { get; set; }

        public bool AutorGrabar { get; set; }

        public bool AutorAprobar { get; set; }

        public bool AutorFactuRemitir { get; set; }

        public bool AutorFactRemision { get; set; }

        public bool CargarAprobadoCC { get; set; }

        public bool RemisionAImpres { get; set; }

        public bool DevolucAImpres { get; set; }

        [StringLength(60)]
        public string? NomRubro16Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro17Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro18Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro19Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro20Cli { get; set; }

        public bool CreaNuevoCliente { get; set; }
    }
}