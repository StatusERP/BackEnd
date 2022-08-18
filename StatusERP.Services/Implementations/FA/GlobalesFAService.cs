using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA
{
    public class GlobalesFAService : IGlobalesFAService
    {
        private readonly IGlobalesFARepository _repository;
        private readonly ILogger<GlobalesFAService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public GlobalesFAService(IGlobalesFARepository repository, ILogger<GlobalesFAService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoGlobalesFA request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_PARMOD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear Globales de Facturación.");
                    response.Success = false;
                    return response;
                }

                var buscarIdGlobalesFA = await _repository.GetAllAsync();
                if (buscarIdGlobalesFA.Count > 0)
                {
                    response.Errors.Add($"El registro de Globales de Facturación ya existe.");
                    response.Success = false;
                    return response;
                }
                response.Result = await _repository.CreateAsync(new GlobalesFA
                {
                    CondPagoContadoId = request.CondPagoContadoId,
                    VendedorObligator = request.VendedorObligator,
                    FactExcPedido = request.FactExcPedido,
                    UsaTarjetaCred = request.UsaTarjetaCred,
                    BodegaPorLinea = request.BodegaPorLinea,
                    PermiteBackorder = request.PermiteBackorder,
                    CancelPedParcial = request.CancelPedParcial,
                    PedAImpresora = request.PedAImpresora,
                    DocAImpresora = request.DocAImpresora,
                    ImpreLoteSeparad = request.ImpreLoteSeparad,
                    FacturaMultipag = request.FacturaMultipag,
                    NCRNumFactura = request.NCRNumFactura,
                    MultipleFMTFactu = request.MultipleFMTFactu,
                    MultipleFMTPedid = request.MultipleFMTPedid,
                    OrdenLineasFact = request.OrdenLineasFact,
                    ReimpresionPedido = request.ReimpresionPedido,
                    ImpPedidoAlFact = request.ImpPedidoAlFact,
                    RedondearFactura = request.RedondearFactura,
                    FactorRedondeo = request.FactorRedondeo,
                    PreciosDec = request.PreciosDec,
                    DescEnPrecio = request.DescEnPrecio,
                    Imp1EnPrecio = request.Imp1EnPrecio,
                    Imp1AfectaDescto = request.Imp1AfectaDescto,
                    AplicaNiPrImp1 = request.AplicaNiPrImp1,
                    NivelPrecioImp1Id = request.NivelPrecioImp1Id,
                    PagoComParcial = request.PagoComParcial,
                    PorcImpComision = request.PorcImpComision,
                    AsientoVentaPor = request.AsientoVentaPor,
                    TipoPartidaId = request.TipoPartidaId,
                    PaqueteId = request.PaqueteId,
                    CtrCtaFleteId = request.CtrCtaFleteId,
                    CtrCtaSeguroId = request.CtrCtaSeguroId,
                    CtrCtaDocumentacionId = request.CtrCtaDocumentacionId,
                    CtrCtaImpuesto1Id = request.CtrCtaImpuesto1Id,
                    CtrCtaImpuesto2Id = request.CtrCtaImpuesto2Id,
                    CtrCtaImpComisioId = request.CtrCtaImpComisioId,
                    UsarRubros = request.UsarRubros,
                    Rubro1Nombre = request.Rubro1Nombre,
                    Rubro2Nombre = request.Rubro2Nombre,
                    Rubro3Nombre = request.Rubro3Nombre,
                    Rubro4Nombre = request.Rubro4Nombre,
                    UsaBoletas = request.UsaBoletas,
                    NomRubro6Cli = request.NomRubro6Cli,
                    NomRubro7Cli = request.NomRubro7Cli,
                    NomRubro8Cli = request.NomRubro8Cli,
                    NomRubro9Cli = request.NomRubro9Cli,
                    Rubro5Nombre = request.Rubro5Nombre,
                    Observaciones = request.Observaciones,
                    NivelPrecioPublicoId = request.NivelPrecioPublicoId,
                    ColumnasEstandar = request.ColumnasEstandar,
                    AsientoCostoPor = request.AsientoCostoPor,
                    CambiarEsqTrab = request.CambiarEsqTrab,
                    FactDocsVencidos = request.FactDocsVencidos,
                    FactCobroJud = request.FactCobroJud,
                    FactLimiteCred = request.FactLimiteCred,
                    ModAplicAsiento = request.ModAplicAsiento,
                    IntegracionConta = request.IntegracionConta,
                    TipoContaOmision = request.TipoContaOmision,
                    TipoCambioId = request.TipoCambioId,
                    PrecisionMaxima = request.PrecisionMaxima,
                    LineasArticulo = request.LineasArticulo,
                    LineasFactura = request.LineasFactura,
                    LineasAdicionales = request.LineasAdicionales,
                    DetalleKits = request.DetalleKits,
                    MonedaPrecios = request.MonedaPrecios,
                    Prevista1 = request.Prevista1,
                    Prevista2 = request.Prevista2,
                    Prevista3 = request.Prevista3,
                    Prevista4 = request.Prevista4,
                    Prevista5 = request.Prevista5,
                    CtrConsumoId = request.CtrConsumoId,
                    CCEnLinea = request.CCEnLinea,
                    CGEnLinea = request.CGEnLinea,
                    UsarAutorizacion = request.UsarAutorizacion,
                    Imp1EnBonifica = request.Imp1EnBonifica,
                    Imp2EnBonifica = request.Imp2EnBonifica,
                    AsientoContCXCPor = request.AsientoContCXCPor,
                    UsarAprobPedidos = request.UsarAprobPedidos,
                    NomRubro10Cli = request.NomRubro10Cli,
                    ListaPrecios = request.ListaPrecios,
                    MargenUtilidad = request.MargenUtilidad,
                    MontoMinimo = request.MontoMinimo,
                    DocVencidos = request.DocVencidos,
                    LimiteCredito = request.LimiteCredito,
                    CobroJudicial = request.CobroJudicial,
                    SinOC = request.SinOC,
                    DiasAtraso = request.DiasAtraso,
                    MontoMinimoLocal = request.MontoMinimoLocal,
                    MontoMinimoDolar = request.MontoMinimoDolar,
                    SaldoMaxLocal = request.SaldoMaxLocal,
                    SaldoMaxDolar = request.SaldoMaxDolar,
                    MaxDiasAtraso = request.MaxDiasAtraso,
                    MaxDocsVenc = request.MaxDocsVenc,
                    PreciosDecDolar = request.PreciosDecDolar,
                    CondPagoNivPre = request.CondPagoNivPre,
                    FactListaPrecios = request.FactListaPrecios,
                    FactMargenUtilid = request.FactMargenUtilid,
                    FactMontoMinimo = request.FactMontoMinimo,
                    FactDiasAtraso = request.FactDiasAtraso,
                    FactSinOC = request.FactSinOC,
                    UsarRubrosVal = request.UsarRubrosVal,
                    ImpDescClasific = request.ImpDescClasific,
                    LimitarMaxLineas = request.LimitarMaxLineas,
                    IndicadPedido = request.IndicadPedido,
                    PrecioCosto = request.PrecioCosto,
                    FactMenorReserva = request.FactMenorReserva,
                    AnulaCXCAplicado = request.AnulaCXCAplicado,
                    TipoCostoNoExist = request.TipoCostoNoExist,
                    CalculoImp2 = request.CalculoImp2,
                    CategoriaClienteId = request.CategoriaClienteId,
                    NivelPrecioId = request.NivelPrecioId,
                    DescuentoCascada = request.DescuentoCascada,
                    Retenciones = request.Retenciones,
                    RetencionesFletes = request.RetencionesFletes,
                    ArticuloId = request.ArticuloId,
                    CodigoRetencion = request.CodigoRetencion,
                    AplicarDescGen = request.AplicarDescGen,
                    ModoDescMult = request.ModoDescMult,
                    DctoGeneral = request.DctoGeneral,
                    FactDctoGeneral = request.FactDctoGeneral,
                    AutorGrabar = request.AutorGrabar,
                    AutorAprobar = request.AutorAprobar,
                    AutorFactuRemitir = request.AutorFactuRemitir,
                    AutorFactRemision = request.AutorFactRemision,
                    CargarAprobadoCC = request.CargarAprobadoCC,
                    RemisionAImpres = request.RemisionAImpres,
                    DevolucAImpres = request.DevolucAImpres,
                    NomRubro16Cli = request.NomRubro16Cli,
                    NomRubro17Cli = request.NomRubro17Cli,
                    NomRubro18Cli = request.NomRubro18Cli,
                    NomRubro19Cli = request.NomRubro19Cli,
                    NomRubro20Cli = request.NomRubro20Cli,
                    CreaNuevoCliente = request.CreaNuevoCliente,
                    IsDeleted = false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now,
                    Createdby = userId,
                    CreateDate = DateTime.Now
                });
                response.Success = true;
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(ex.Message);
            }

            return response;
        }


        public async Task<BaseResponseGeneric<ICollection<GlobalesFA>>> GetAsync(string userId)
        {
            var response = new BaseResponseGeneric<ICollection<GlobalesFA>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_PARMOD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar valores globales de facturación.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.GetAllAsync();
                response.Success = true;
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoGlobalesFA request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_ADMIN_PARMODMOD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar valores globales de facturación.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new GlobalesFA
                {
                    Id = id,
                    CondPagoContadoId = request.CondPagoContadoId,
                    VendedorObligator = request.VendedorObligator,
                    FactExcPedido = request.FactExcPedido,
                    UsaTarjetaCred = request.UsaTarjetaCred,
                    BodegaPorLinea = request.BodegaPorLinea,
                    PermiteBackorder = request.PermiteBackorder,
                    CancelPedParcial = request.CancelPedParcial,
                    PedAImpresora = request.PedAImpresora,
                    DocAImpresora = request.DocAImpresora,
                    ImpreLoteSeparad = request.ImpreLoteSeparad,
                    FacturaMultipag = request.FacturaMultipag,
                    NCRNumFactura = request.NCRNumFactura,
                    MultipleFMTFactu = request.MultipleFMTFactu,
                    MultipleFMTPedid = request.MultipleFMTPedid,
                    OrdenLineasFact = request.OrdenLineasFact,
                    ReimpresionPedido = request.ReimpresionPedido,
                    ImpPedidoAlFact = request.ImpPedidoAlFact,
                    RedondearFactura = request.RedondearFactura,
                    FactorRedondeo = request.FactorRedondeo,
                    PreciosDec = request.PreciosDec,
                    DescEnPrecio = request.DescEnPrecio,
                    Imp1EnPrecio = request.Imp1EnPrecio,
                    Imp1AfectaDescto = request.Imp1AfectaDescto,
                    AplicaNiPrImp1 = request.AplicaNiPrImp1,
                    NivelPrecioImp1Id = request.NivelPrecioImp1Id,
                    PagoComParcial = request.PagoComParcial,
                    PorcImpComision = request.PorcImpComision,
                    AsientoVentaPor = request.AsientoVentaPor,
                    TipoPartidaId = request.TipoPartidaId,
                    PaqueteId = request.PaqueteId,
                    CtrCtaFleteId = request.CtrCtaFleteId,
                    CtrCtaSeguroId = request.CtrCtaSeguroId,
                    CtrCtaDocumentacionId = request.CtrCtaDocumentacionId,
                    CtrCtaImpuesto1Id = request.CtrCtaImpuesto1Id,
                    CtrCtaImpuesto2Id = request.CtrCtaImpuesto2Id,
                    CtrCtaImpComisioId = request.CtrCtaImpComisioId,
                    UsarRubros = request.UsarRubros,
                    Rubro1Nombre = request.Rubro1Nombre,
                    Rubro2Nombre = request.Rubro2Nombre,
                    Rubro3Nombre = request.Rubro3Nombre,
                    Rubro4Nombre = request.Rubro4Nombre,
                    UsaBoletas = request.UsaBoletas,
                    NomRubro6Cli = request.NomRubro6Cli,
                    NomRubro7Cli = request.NomRubro7Cli,
                    NomRubro8Cli = request.NomRubro8Cli,
                    NomRubro9Cli = request.NomRubro9Cli,
                    Rubro5Nombre = request.Rubro5Nombre,
                    Observaciones = request.Observaciones,
                    NivelPrecioPublicoId = request.NivelPrecioPublicoId,
                    ColumnasEstandar = request.ColumnasEstandar,
                    AsientoCostoPor = request.AsientoCostoPor,
                    CambiarEsqTrab = request.CambiarEsqTrab,
                    FactDocsVencidos = request.FactDocsVencidos,
                    FactCobroJud = request.FactCobroJud,
                    FactLimiteCred = request.FactLimiteCred,
                    ModAplicAsiento = request.ModAplicAsiento,
                    IntegracionConta = request.IntegracionConta,
                    TipoContaOmision = request.TipoContaOmision,
                    TipoCambioId = request.TipoCambioId,
                    PrecisionMaxima = request.PrecisionMaxima,
                    LineasArticulo = request.LineasArticulo,
                    LineasFactura = request.LineasFactura,
                    LineasAdicionales = request.LineasAdicionales,
                    DetalleKits = request.DetalleKits,
                    MonedaPrecios = request.MonedaPrecios,
                    Prevista1 = request.Prevista1,
                    Prevista2 = request.Prevista2,
                    Prevista3 = request.Prevista3,
                    Prevista4 = request.Prevista4,
                    Prevista5 = request.Prevista5,
                    CtrConsumoId = request.CtrConsumoId,
                    CCEnLinea = request.CCEnLinea,
                    CGEnLinea = request.CGEnLinea,
                    UsarAutorizacion = request.UsarAutorizacion,
                    Imp1EnBonifica = request.Imp1EnBonifica,
                    Imp2EnBonifica = request.Imp2EnBonifica,
                    AsientoContCXCPor = request.AsientoContCXCPor,
                    UsarAprobPedidos = request.UsarAprobPedidos,
                    NomRubro10Cli = request.NomRubro10Cli,
                    ListaPrecios = request.ListaPrecios,
                    MargenUtilidad = request.MargenUtilidad,
                    MontoMinimo = request.MontoMinimo,
                    DocVencidos = request.DocVencidos,
                    LimiteCredito = request.LimiteCredito,
                    CobroJudicial = request.CobroJudicial,
                    SinOC = request.SinOC,
                    DiasAtraso = request.DiasAtraso,
                    MontoMinimoLocal = request.MontoMinimoLocal,
                    MontoMinimoDolar = request.MontoMinimoDolar,
                    SaldoMaxLocal = request.SaldoMaxLocal,
                    SaldoMaxDolar = request.SaldoMaxDolar,
                    MaxDiasAtraso = request.MaxDiasAtraso,
                    MaxDocsVenc = request.MaxDocsVenc,
                    PreciosDecDolar = request.PreciosDecDolar,
                    CondPagoNivPre = request.CondPagoNivPre,
                    FactListaPrecios = request.FactListaPrecios,
                    FactMargenUtilid = request.FactMargenUtilid,
                    FactMontoMinimo = request.FactMontoMinimo,
                    FactDiasAtraso = request.FactDiasAtraso,
                    FactSinOC = request.FactSinOC,
                    UsarRubrosVal = request.UsarRubrosVal,
                    ImpDescClasific = request.ImpDescClasific,
                    LimitarMaxLineas = request.LimitarMaxLineas,
                    IndicadPedido = request.IndicadPedido,
                    PrecioCosto = request.PrecioCosto,
                    FactMenorReserva = request.FactMenorReserva,
                    AnulaCXCAplicado = request.AnulaCXCAplicado,
                    TipoCostoNoExist = request.TipoCostoNoExist,
                    CalculoImp2 = request.CalculoImp2,
                    CategoriaClienteId = request.CategoriaClienteId,
                    NivelPrecioId = request.NivelPrecioId,
                    DescuentoCascada = request.DescuentoCascada,
                    Retenciones = request.Retenciones,
                    RetencionesFletes = request.RetencionesFletes,
                    ArticuloId = request.ArticuloId,
                    CodigoRetencion = request.CodigoRetencion,
                    AplicarDescGen = request.AplicarDescGen,
                    ModoDescMult = request.ModoDescMult,
                    DctoGeneral = request.DctoGeneral,
                    FactDctoGeneral = request.FactDctoGeneral,
                    AutorGrabar = request.AutorGrabar,
                    AutorAprobar = request.AutorAprobar,
                    AutorFactuRemitir = request.AutorFactuRemitir,
                    AutorFactRemision = request.AutorFactRemision,
                    CargarAprobadoCC = request.CargarAprobadoCC,
                    RemisionAImpres = request.RemisionAImpres,
                    DevolucAImpres = request.DevolucAImpres,
                    NomRubro16Cli = request.NomRubro16Cli,
                    NomRubro17Cli = request.NomRubro17Cli,
                    NomRubro18Cli = request.NomRubro18Cli,
                    NomRubro19Cli = request.NomRubro19Cli,
                    NomRubro20Cli = request.NomRubro20Cli,
                    CreaNuevoCliente = request.CreaNuevoCliente,
                    IsDeleted = false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now
                });
                response.Success = true;
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(ex.Message);
            }
            return response;
        }
    }
}
