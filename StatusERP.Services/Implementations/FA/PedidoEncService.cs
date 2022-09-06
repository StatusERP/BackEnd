using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA;


public class PedidoEncService : IPedidoEncService
{
    private readonly IPedidoEncRepository _repository;
    private readonly ILogger<PedidoEncService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public PedidoEncService(IPedidoEncRepository repository, ILogger<PedidoEncService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoPedidoEnc request, string userId, string pedido)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_PEDIDOADD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear pedidos.");
                response.Success = false;
                return response;
            }

            var buscarPedido = await _repository.BuscarPedidoAsync(pedido);
            if (buscarPedido != null)
            {
                throw new Exception($"El número de pedido {buscarPedido.Pedido} ya existe.");
            }
            response.Result = await _repository.CreateAsync(new PedidoEnc
            {
                Pedido = request.Pedido,
                Estado = request.Estado,
                FechaPedido = request.FechaPedido,
                Fecha_Prometida = request.Fecha_Prometida,
                FechaProxEmbarqu = request.FechaProxEmbarqu,
                FechaUltEmbarque = request.FechaUltEmbarque,
                FechaUltCancelac = request.FechaUltCancelac,
                OrdenCompra = request.OrdenCompra,
                FechaOrden = request.FechaOrden,
                TarjetaCredito = request.TarjetaCredito,
                EmbarcarA = request.EmbarcarA,
                DirecEmbarque = request.DirecEmbarque,
                Rubro1 = request.Rubro1,
                Rubro2 = request.Rubro2,
                Rubro3 = request.Rubro3,
                Rubro4 = request.Rubro4,
                Rubro5 = request.Rubro5,
                Observaciones = request.Observaciones,
                ComentarioCXC = request.ComentarioCXC,
                TotalMercaderia = request.TotalMercaderia,
                MontoAnticipo = request.MontoAnticipo,
                MontoFlete = request.MontoFlete,
                MontoSeguro = request.MontoSeguro,
                MontoDocumentacio = request.MontoDocumentacio,
                TipoDescuento1 = request.TipoDescuento1,
                TipoDescuento2 = request.TipoDescuento2,
                MontoDescuento1 = request.MontoDescuento1,
                MontoDescuento2 = request.MontoDescuento2,
                PorcDescuento1 = request.PorcDescuento1,
                PorcDescuento2 = request.PorcDescuento2,
                TotalImpuesto1 = request.TotalImpuesto1,
                TotalImpuesto2 = request.TotalImpuesto2,
                TotalAFacturar = request.TotalAFacturar,
                PorcComiVendedor = request.PorcComiVendedor,
                PorcComiCobrador = request.PorcComiCobrador,
                TotalCancelado = request.TotalCancelado,
                TotalUnidades = request.TotalUnidades,
                Impreso = request.Impreso,
                FechaHora = request.FechaHora,
                DescuentoVolumen = request.DescuentoVolumen,
                TipoPedido = request.TipoPedido,
                MonedaPedido = request.MonedaPedido,
                VersionNivelPrecioId = request.VersionNivelPrecioId,
                Autorizado = request.Autorizado,
                DocAGenerar = request.DocAGenerar,
                ClasePedido = request.ClasePedido,
                CobradorId = request.CobradorId,
                RutaId  = request.RutaId,
                Usuario = request.Usuario,
                CondicionPagoId = request.CondicionPagoId,
                BodegaId = request.BodegaId,
                ZonaId = request.ZonaId,
                VendedorId = request.VendedorId,
                ClienteId = request.ClienteId,
                CodCliente = request.CodCliente,
                ClienteDireccionId = request.ClienteDireccionId,
                ClienteCorporacId = request.ClienteCorporacId,
                ClienteOrigenId = request.ClienteOrigenId,
                PaisId = request.PaisId,
                SubTipoDocCCId = request.SubTipoDocCCId,
                Backorder = request.Backorder,
                PorcIntCte = request.PorcIntCte,
                DescuentoCascada = request.DescuentoCascada,
                DireccionFactura = request.DireccionFactura,
                TipoCambio = request.TipoCambio,
                FijarTipoCambio = request.FijarTipoCambio,
                OrigenPedido = request.OrigenPedido,
                DescDirecEmbarque = request.DescDirecEmbarque,
                DivisionGeografica1 = request.DivisionGeografica1,
                DivisionGeografica2 = request.DivisionGeografica2,
                BaseImpuesto1 = request.BaseImpuesto1,
                BaseImpuesto2 = request.BaseImpuesto2,
                NombreCliente = request.NombreCliente,
                FechaProyectada = request.FechaProyectada,
                FechaAprobacion = request.FechaAprobacion,
                TipoDocumento = request.TipoDocumento,
                VersionCotizacion = request.VersionCotizacion,
                RazonCancelaCoti = request.RazonCancelaCoti,
                DesCancelaCoti = request.DesCancelaCoti,
                CambiosCoti = request.CambiosCoti,
                CotizacionPadre = request.CotizacionPadre,
                TasaImpositiva = request.TasaImpositiva,
                TasaImpositivaPorc = request.TasaImpositivaPorc,
                TasaCree1 = request.TasaCree1,
                TasaCree1Porc = request.TasaCree1Porc,
                TasaCree2 = request.TasaCree2,
                TasaCree2Porc = request.TasaCree2Porc,
                TasaGanOcasionalPorc = request.TasaGanOcasionalPorc,
                UsrNoAprueba = request.UsrNoAprueba,
                FechaNoAprueba = request.FechaNoAprueba,
                RazonDesaprueba = request.RazonDesaprueba,
                Modulo = request.Modulo,
                CorreosEnvio = request.CorreosEnvio,
                Incoterms = request.Incoterms,
                TipoOperacion = request.TipoOperacion,
                ActividadComercial = request.ActividadComercial,
                MontoOtroCargo = request.MontoOtroCargo,
                TieneRelacionados = request.TieneRelacionados,
                EsFacturaReemplazo = request.EsFacturaReemplazo,
                FacturaOriginalReemplazo = request.FacturaOriginalReemplazo,
                ConsecutivoFTC = request.ConsecutivoFTC,
                NumeroFTC = request.NumeroFTC,
                NITTransportador = request.NITTransportador,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_PEDIDODEL", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar pedidos.");
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

    public async Task<BaseResponseGeneric<ICollection<PedidoEnc>>> GetAsync(int page, int rows, string userId)
    {
        var response = new BaseResponseGeneric<ICollection<PedidoEnc>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_PEDIDO", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar pedidos.");
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

    public async Task<BaseResponseGeneric<PedidoEnc>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<PedidoEnc>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new PedidoEnc();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPedidoEnc request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_PEDIDOMOD", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar pedidos.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new PedidoEnc
            {
                Id = id,
                Pedido = request.Pedido,
                Estado = request.Estado,
                FechaPedido = request.FechaPedido,
                Fecha_Prometida = request.Fecha_Prometida,
                FechaProxEmbarqu = request.FechaProxEmbarqu,
                FechaUltEmbarque = request.FechaUltEmbarque,
                FechaUltCancelac = request.FechaUltCancelac,
                OrdenCompra = request.OrdenCompra,
                FechaOrden = request.FechaOrden,
                TarjetaCredito = request.TarjetaCredito,
                EmbarcarA = request.EmbarcarA,
                DirecEmbarque = request.DirecEmbarque,
                Rubro1 = request.Rubro1,
                Rubro2 = request.Rubro2,
                Rubro3 = request.Rubro3,
                Rubro4 = request.Rubro4,
                Rubro5 = request.Rubro5,
                Observaciones = request.Observaciones,
                ComentarioCXC = request.ComentarioCXC,
                TotalMercaderia = request.TotalMercaderia,
                MontoAnticipo = request.MontoAnticipo,
                MontoFlete = request.MontoFlete,
                MontoSeguro = request.MontoSeguro,
                MontoDocumentacio = request.MontoDocumentacio,
                TipoDescuento1 = request.TipoDescuento1,
                TipoDescuento2 = request.TipoDescuento2,
                MontoDescuento1 = request.MontoDescuento1,
                MontoDescuento2 = request.MontoDescuento2,
                PorcDescuento1 = request.PorcDescuento1,
                PorcDescuento2 = request.PorcDescuento2,
                TotalImpuesto1 = request.TotalImpuesto1,
                TotalImpuesto2 = request.TotalImpuesto2,
                TotalAFacturar = request.TotalAFacturar,
                PorcComiVendedor = request.PorcComiVendedor,
                PorcComiCobrador = request.PorcComiCobrador,
                TotalCancelado = request.TotalCancelado,
                TotalUnidades = request.TotalUnidades,
                Impreso = request.Impreso,
                FechaHora = request.FechaHora,
                DescuentoVolumen = request.DescuentoVolumen,
                TipoPedido = request.TipoPedido,
                MonedaPedido = request.MonedaPedido,
                VersionNivelPrecioId = request.VersionNivelPrecioId,
                Autorizado = request.Autorizado,
                DocAGenerar = request.DocAGenerar,
                ClasePedido = request.ClasePedido,
                CobradorId = request.CobradorId,
                RutaId = request.RutaId,
                Usuario = request.Usuario,
                CondicionPagoId = request.CondicionPagoId,
                BodegaId = request.BodegaId,
                ZonaId = request.ZonaId,
                VendedorId = request.VendedorId,
                ClienteId = request.ClienteId,
                CodCliente = request.CodCliente,
                ClienteDireccionId = request.ClienteDireccionId,
                ClienteCorporacId = request.ClienteCorporacId,
                ClienteOrigenId = request.ClienteOrigenId,
                PaisId = request.PaisId,
                SubTipoDocCCId = request.SubTipoDocCCId,
                Backorder = request.Backorder,
                PorcIntCte = request.PorcIntCte,
                DescuentoCascada = request.DescuentoCascada,
                DireccionFactura = request.DireccionFactura,
                TipoCambio = request.TipoCambio,
                FijarTipoCambio = request.FijarTipoCambio,
                OrigenPedido = request.OrigenPedido,
                DescDirecEmbarque = request.DescDirecEmbarque,
                DivisionGeografica1 = request.DivisionGeografica1,
                DivisionGeografica2 = request.DivisionGeografica2,
                BaseImpuesto1 = request.BaseImpuesto1,
                BaseImpuesto2 = request.BaseImpuesto2,
                NombreCliente = request.NombreCliente,
                FechaProyectada = request.FechaProyectada,
                FechaAprobacion = request.FechaAprobacion,
                TipoDocumento = request.TipoDocumento,
                VersionCotizacion = request.VersionCotizacion,
                RazonCancelaCoti = request.RazonCancelaCoti,
                DesCancelaCoti = request.DesCancelaCoti,
                CambiosCoti = request.CambiosCoti,
                CotizacionPadre = request.CotizacionPadre,
                TasaImpositiva = request.TasaImpositiva,
                TasaImpositivaPorc = request.TasaImpositivaPorc,
                TasaCree1 = request.TasaCree1,
                TasaCree1Porc = request.TasaCree1Porc,
                TasaCree2 = request.TasaCree2,
                TasaCree2Porc = request.TasaCree2Porc,
                TasaGanOcasionalPorc = request.TasaGanOcasionalPorc,
                UsrNoAprueba = request.UsrNoAprueba,
                FechaNoAprueba = request.FechaNoAprueba,
                RazonDesaprueba = request.RazonDesaprueba,
                Modulo = request.Modulo,
                CorreosEnvio = request.CorreosEnvio,
                Incoterms = request.Incoterms,
                TipoOperacion = request.TipoOperacion,
                ActividadComercial = request.ActividadComercial,
                MontoOtroCargo = request.MontoOtroCargo,
                TieneRelacionados = request.TieneRelacionados,
                EsFacturaReemplazo = request.EsFacturaReemplazo,
                FacturaOriginalReemplazo = request.FacturaOriginalReemplazo,
                ConsecutivoFTC = request.ConsecutivoFTC,
                NumeroFTC = request.NumeroFTC,
                NITTransportador = request.NITTransportador,
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