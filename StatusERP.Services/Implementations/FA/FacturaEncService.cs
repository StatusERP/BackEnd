using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA;


public class FacturaEncService : IFacturaEncService
{
    private readonly IFacturaEncRepository _repository;
    private readonly ILogger<FacturaEncService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public FacturaEncService(IFacturaEncRepository repository, ILogger<FacturaEncService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoFacturaEnc request, string userId, string tipoFactura, string factura)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_PEDIDO_FACTURA", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear Encabezados de Facturas.");
                response.Success = false;
                return response;
            }

            var buscarFactura = await _repository.BuscarFacturaEncAsync(tipoFactura, factura);
            if (buscarFactura != null)
            {
                throw new Exception($"El número de Factura {buscarFactura.Factura} ya existe para el tipo {buscarFactura.TipoDocumento}.");
            }
            response.Result = await _repository.CreateAsync(new FacturaEnc
            {
                TipoDocumento = request.TipoDocumento,
                Factura = request.Factura,
                MovInventarioEncId = request.MovInventarioEncId,
                EnInvestigacion = request.EnInvestigacion,
                TransAdicionales = request.TransAdicionales,
                EstadoRemision = request.EstadoRemision,
                PartidaDocumento = request.PartidaDocumento,
                DescuentoVolumen = request.DescuentoVolumen,
                MonedaFactura = request.MonedaFactura,
                ComentarioCXC = request.ComentarioCXC,
                FechaDespacho = request.FechaDespacho,
                ClaseDocumento = request.ClaseDocumento,
                FechaRecibido = request.FechaRecibido,
                Pedido = request.Pedido,
                FacturaOriginal = request.FacturaOriginal,
                TipoOriginal = request.TipoOriginal,
                ComisionCobrador = request.ComisionCobrador,
                TarjetaCredito = request.TarjetaCredito,
                TotalVolumen = request.TotalVolumen,
                NumeroAutoriza = request.NumeroAutoriza,
                TotalPeso = request.TotalPeso,
                MontoCobrado = request.MontoCobrado,
                TotalImpuesto1 = request.TotalImpuesto1,
                Fecha = request.Fecha,
                FechaEntrega = request.FechaEntrega,
                TotalImpuesto2 = request.TotalImpuesto2,
                PorDescuento2 = request.PorDescuento2,
                MontoFlete = request.MontoFlete,
                MontoSeguro = request.MontoSeguro,
                MontoDocumentacio = request.MontoDocumentacio,
                TipoDescuento1 = request.TipoDescuento1,
                TipoDescuento2 = request.TipoDescuento2,
                MontoDescuento1 = request.MontoDescuento1,
                MontoDescuento2 = request.MontoDescuento2,
                PorcDescuento1 = request.PorcDescuento1,
                TotalFactura = request.TotalFactura,
                FechaPedido = request.FechaPedido,
                FechaHoraAnula = request.FechaHoraAnula,
                FechaOrden = request.FechaOrden,
                TotalMercaderia = request.TotalMercaderia,
                ComisionVendedor = request.ComisionVendedor,
                OrdenCompra = request.OrdenCompra,
                FechaHora = request.FechaHora,
                TotalUnidades = request.TotalUnidades,
                NumeroPaginas = request.NumeroPaginas,
                TipoCambio = request.TipoCambio,
                Anulada = request.Anulada,
                Modulo = request.Modulo,
                CargadoCG = request.CargadoCG,
                CargadoCXC = request.CargadoCXC,
                EmbarcarA = request.EmbarcarA,
                DirecEmbarque = request.DirecEmbarque,
                MultiplicadorEV = request.MultiplicadorEV,
                Observaciones = request.Observaciones,
                Rubro1 = request.Rubro1,
                Rubro2 = request.Rubro2,
                Rubro3 = request.Rubro3,
                Rubro4 = request.Rubro4,
                Rubro5 = request.Rubro5,
                VersionNPId = request.VersionNPId,
                CobradorId = request.CobradorId,
                RutaId = request.RutaId,
                Usuario = request.Usuario,
                UsuarioAnula = request.UsuarioAnula,
                CondicionPagoId = request.CondicionPagoId,
                ZonaId = request.ZonaId,
                VendedorId = request.VendedorId,
                DocCreditoCCId = request.DocCreditoCCId,
                ClienteDireccionId = request.ClienteDireccionId,
                ClienteCorporacId = request.ClienteCorporacId,
                ClienteOrigenId = request.ClienteOrigenId,
                ClienteId = request.ClienteId,
                PaisId = request.PaisId,
                SubTipoDocCCId = request.SubTipoDocCCId,
                MontoAnticipo = request.MontoAnticipo,
                TotalPesoNeto = request.TotalPesoNeto,
                FechaRige = request.FechaRige,
                PorcIntCte = request.PorcIntCte,
                Cobrada = request.Cobrada,
                DescuentoCascada = request.DescuentoCascada,
                DireccionFactura = request.DireccionFactura,
                DireccEmbarqueId = request.DireccEmbarqueId,
                ConsecutivoId = request.ConsecutivoId,
                Reimpreso = request.Reimpreso,
                DivisionGeografica1Id = request.DivisionGeografica1Id,
                DivisionGeografica2Id = request.DivisionGeografica2Id,
                BaseImpuesto1 = request.BaseImpuesto1,
                BaseImpuesto2 = request.BaseImpuesto2,
                NombreCliente = request.NombreCliente,
                DocFiscal = request.DocFiscal,
                NombreMaquina = request.NombreMaquina,
                SerieResolución = request.SerieResolución,
                ConsecResolucion = request.ConsecResolucion,
                GeneraDocFE = request.GeneraDocFE,
                TasaImpositiva = request.TasaImpositiva,
                TasaImpositivaPorc = request.TasaImpositivaPorc,
                TasaCree1 = request.TasaCree1,
                TasaCree1Porc = request.TasaCree1Porc,
                TasaCree2 = request.TasaCree2,
                TasaCree2Porc = request.TasaCree2Porc,
                AjusteRedondeo = request.AjusteRedondeo,
                FormaPago = request.FormaPago,
                JustiDevHaciend = request.JustiDevHaciend,
                Incoterms = request.Incoterms,
                MontoOtroCargo = request.MontoOtroCargo,
                MontoTotalIVADevuelto = request.MontoTotalIVADevuelto,
                Cancelacion = request.Cancelacion,
                EstadoCancelación = request.EstadoCancelación,
                TieneRelacionados = request.TieneRelacionados,
                Prefijo = request.Prefijo,
                FechaInicioResolucion = request.FechaInicioResolucion,
                FechaFinalResolucion = request.FechaFinalResolucion,
                ClaveTecnica = request.ClaveTecnica,
                MatriculaMercantil = request.MatriculaMercantil,
                EsFacturaReemplazo = request.EsFacturaReemplazo,
                FacOriginalReemplazoId = request.FacOriginalReemplazoId,
                ConsecutivoFTC = request.ConsecutivoFTC,
                NumeroFTC = request.NumeroFTC,
                NITTransportador = request.NITTransportador,
                NCFModificado = request.NCFModificado,
                NumOCExenta = request.NumOCExenta,
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

    public async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
    {

        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_PEDIDO_FACTURA", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar Facturas.");
                response.Success = false;
                return response;
            }


            await _repository.DeleteAsync(id, userId);
            response.Success = true;
            response.Result = id;
        }
        catch (Exception ex)
        {
            _logger.LogCritical(ex.StackTrace);
            response.Success = false;
            response.Errors.Add(ex.Message);
        }

        return response;
    }

    public async Task<BaseResponseGeneric<ICollection<FacturaEnc>>> GetAsync(int page, int rows, string userId)
    {
        var response = new BaseResponseGeneric<ICollection<FacturaEnc>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_PEDIDO_FACTURA", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar Facturas.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.GetCollectionAsync();
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

    public async Task<BaseResponseGeneric<FacturaEnc>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<FacturaEnc>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new FacturaEnc();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoFacturaEnc request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_PEDIDO_FACTURA", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar Facturas.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new FacturaEnc
            {
                Id = id,
                TipoDocumento = request.TipoDocumento,
                Factura = request.Factura,
                MovInventarioEncId = request.MovInventarioEncId,
                EnInvestigacion = request.EnInvestigacion,
                TransAdicionales = request.TransAdicionales,
                EstadoRemision = request.EstadoRemision,
                PartidaDocumento = request.PartidaDocumento,
                DescuentoVolumen = request.DescuentoVolumen,
                MonedaFactura = request.MonedaFactura,
                ComentarioCXC = request.ComentarioCXC,
                FechaDespacho = request.FechaDespacho,
                ClaseDocumento = request.ClaseDocumento,
                FechaRecibido = request.FechaRecibido,
                Pedido = request.Pedido,
                FacturaOriginal = request.FacturaOriginal,
                TipoOriginal = request.TipoOriginal,
                ComisionCobrador = request.ComisionCobrador,
                TarjetaCredito = request.TarjetaCredito,
                TotalVolumen = request.TotalVolumen,
                NumeroAutoriza = request.NumeroAutoriza,
                TotalPeso = request.TotalPeso,
                MontoCobrado = request.MontoCobrado,
                TotalImpuesto1 = request.TotalImpuesto1,
                Fecha = request.Fecha,
                FechaEntrega = request.FechaEntrega,
                TotalImpuesto2 = request.TotalImpuesto2,
                PorDescuento2 = request.PorDescuento2,
                MontoFlete = request.MontoFlete,
                MontoSeguro = request.MontoSeguro,
                MontoDocumentacio = request.MontoDocumentacio,
                TipoDescuento1 = request.TipoDescuento1,
                TipoDescuento2 = request.TipoDescuento2,
                MontoDescuento1 = request.MontoDescuento1,
                MontoDescuento2 = request.MontoDescuento2,
                PorcDescuento1 = request.PorcDescuento1,
                TotalFactura = request.TotalFactura,
                FechaPedido = request.FechaPedido,
                FechaHoraAnula = request.FechaHoraAnula,
                FechaOrden = request.FechaOrden,
                TotalMercaderia = request.TotalMercaderia,
                ComisionVendedor = request.ComisionVendedor,
                OrdenCompra = request.OrdenCompra,
                FechaHora = request.FechaHora,
                TotalUnidades = request.TotalUnidades,
                NumeroPaginas = request.NumeroPaginas,
                TipoCambio = request.TipoCambio,
                Anulada = request.Anulada,
                Modulo = request.Modulo,
                CargadoCG = request.CargadoCG,
                CargadoCXC = request.CargadoCXC,
                EmbarcarA = request.EmbarcarA,
                DirecEmbarque = request.DirecEmbarque,
                MultiplicadorEV = request.MultiplicadorEV,
                Observaciones = request.Observaciones,
                Rubro1 = request.Rubro1,
                Rubro2 = request.Rubro2,
                Rubro3 = request.Rubro3,
                Rubro4 = request.Rubro4,
                Rubro5 = request.Rubro5,
                VersionNPId = request.VersionNPId,
                CobradorId = request.CobradorId,
                RutaId = request.RutaId,
                Usuario = request.Usuario,
                UsuarioAnula = request.UsuarioAnula,
                CondicionPagoId = request.CondicionPagoId,
                ZonaId = request.ZonaId,
                VendedorId = request.VendedorId,
                DocCreditoCCId = request.DocCreditoCCId,
                ClienteDireccionId = request.ClienteDireccionId,
                ClienteCorporacId = request.ClienteCorporacId,
                ClienteOrigenId = request.ClienteOrigenId,
                ClienteId = request.ClienteId,
                PaisId = request.PaisId,
                SubTipoDocCCId = request.SubTipoDocCCId,
                MontoAnticipo = request.MontoAnticipo,
                TotalPesoNeto = request.TotalPesoNeto,
                FechaRige = request.FechaRige,
                PorcIntCte = request.PorcIntCte,
                Cobrada = request.Cobrada,
                DescuentoCascada = request.DescuentoCascada,
                DireccionFactura = request.DireccionFactura,
                DireccEmbarqueId = request.DireccEmbarqueId,
                ConsecutivoId = request.ConsecutivoId,
                Reimpreso = request.Reimpreso,
                DivisionGeografica1Id = request.DivisionGeografica1Id,
                DivisionGeografica2Id = request.DivisionGeografica2Id,
                BaseImpuesto1 = request.BaseImpuesto1,
                BaseImpuesto2 = request.BaseImpuesto2,
                NombreCliente = request.NombreCliente,
                DocFiscal = request.DocFiscal,
                NombreMaquina = request.NombreMaquina,
                SerieResolución = request.SerieResolución,
                ConsecResolucion = request.ConsecResolucion,
                GeneraDocFE = request.GeneraDocFE,
                TasaImpositiva = request.TasaImpositiva,
                TasaImpositivaPorc = request.TasaImpositivaPorc,
                TasaCree1 = request.TasaCree1,
                TasaCree1Porc = request.TasaCree1Porc,
                TasaCree2 = request.TasaCree2,
                TasaCree2Porc = request.TasaCree2Porc,
                AjusteRedondeo = request.AjusteRedondeo,
                FormaPago = request.FormaPago,
                JustiDevHaciend = request.JustiDevHaciend,
                Incoterms = request.Incoterms,
                MontoOtroCargo = request.MontoOtroCargo,
                MontoTotalIVADevuelto = request.MontoTotalIVADevuelto,
                Cancelacion = request.Cancelacion,
                EstadoCancelación = request.EstadoCancelación,
                TieneRelacionados = request.TieneRelacionados,
                Prefijo = request.Prefijo,
                FechaInicioResolucion = request.FechaInicioResolucion,
                FechaFinalResolucion = request.FechaFinalResolucion,
                ClaveTecnica = request.ClaveTecnica,
                MatriculaMercantil = request.MatriculaMercantil,
                EsFacturaReemplazo = request.EsFacturaReemplazo,
                FacOriginalReemplazoId = request.FacOriginalReemplazoId,
                ConsecutivoFTC = request.ConsecutivoFTC,
                NumeroFTC = request.NumeroFTC,
                NITTransportador = request.NITTransportador,
                NCFModificado = request.NCFModificado,
                NumOCExenta = request.NumOCExenta,
                Updatedby = userId,
                UpdateDate = DateTime.Now,
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