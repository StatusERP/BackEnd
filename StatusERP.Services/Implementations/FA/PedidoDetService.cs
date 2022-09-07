using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Services.Interfaces.FA;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.FA;


public class PedidoDetService : IPedidoDetService
{
    private readonly IPedidoDetRepository _repository;
    private readonly ILogger<PedidoDetService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

    public PedidoDetService(IPedidoDetRepository repository, ILogger<PedidoDetService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
    }

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoPedidoDet request, string userId, int pedidoEncId, Int16 pedidoLinea)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_PEDIDO_LINEA", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear líneas de pedidos.");
                response.Success = false;
                return response;
            }

            var buscarPedido = await _repository.BuscarPedidoDetAsync(pedidoEncId, pedidoLinea);
            if (buscarPedido != null)
            {
                throw new Exception($"El número de linea {buscarPedido.PedidoLinea} ya existe para el pedido {buscarPedido.PedidoEncId}.");
            }
            response.Result = await _repository.CreateAsync(new PedidoDet
            {
                PedidoEncId = request.PedidoEncId,
                PedidoLinea = request.PedidoLinea,
                BodegaId = request.BodegaId,
                LoteId = request.LoteId,
                LocalizacionId = request.LocalizacionId,
                ArticuloId = request.ArticuloId,
                Estado = request.Estado,
                FechaEntrega = request.FechaEntrega,
                LineaUsuario = request.LineaUsuario,
                PrecioUnitario = request.PrecioUnitario,
                CantidadPedida = request.CantidadPedida,
                CantidadAFacturar = request.CantidadAFacturar,
                CantidadFacturada = request.CantidadFacturada,
                CantidadReservada = request.CantidadReservada,
                CantidadBonificada = request.CantidadBonificada,
                CantidadCancelada = request.CantidadCancelada,
                TipoDescuento = request.TipoDescuento,
                MontoDescuento = request.MontoDescuento,
                PorcDescuento = request.PorcDescuento,
                Descripcion = request.Descripcion,
                Comentario = request.Comentario,
                PedidoLineaBonif = request.PedidoLineaBonif,
                UnidadDistribucionId = request.UnidadDistribucionId,
                FechaPrometida = request.FechaPrometida,
                LineaOrdenCompra = request.LineaOrdenCompra,
                CentroCuentaId = request.CentroCuentaId,
                RazonPerdida = request.RazonPerdida,
                TipoImpuesto1 = request.TipoImpuesto1,
                TipoTarifa1 = request.TipoTarifa1,
                TipoImpuesto2 = request.TipoImpuesto2,
                TipoTarifa2 = request.TipoTarifa2,
                PorcExoneracion = request.PorcExoneracion,
                MontoExoneracion = request.MontoExoneracion,
                PorcImpuesto1 = request.PorcImpuesto1,
                PorcImpuesto2 = request.PorcImpuesto2,
                EsOtroCargo = request.EsOtroCargo,
                EsCanastaBasica = request.EsCanastaBasica,
                PorcExoneracion2 = request.PorcExoneracion2,
                MontoExoneracion2 = request.MontoExoneracion2,
                PorcImp1Base = request.PorcImp1Base,
                PorcImp2Base = request.PorcImp2Base,
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
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_PEDIDO_LINEA", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para eliminar líneas de pedido.");
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

    public async Task<BaseResponseGeneric<ICollection<PedidoDet>>> GetAsync(int page, int rows, string userId)
    {
        var response = new BaseResponseGeneric<ICollection<PedidoDet>>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_CONSUL_PEDLN", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar líneas de pedidos.");
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

    public async Task<BaseResponseGeneric<PedidoDet>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<PedidoDet>();
        try
        {
            response.Result = await _repository.GetByIdAsync(id) ?? new PedidoDet();
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

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPedidoDet request, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("FA_PEDIDO_LINEA", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar líneas de pedidos.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new PedidoDet
            {
                Id = id,
                PedidoEncId = request.PedidoEncId,
                PedidoLinea = request.PedidoLinea,
                BodegaId = request.BodegaId,
                LoteId = request.LoteId,
                LocalizacionId = request.LocalizacionId,
                ArticuloId = request.ArticuloId,
                Estado = request.Estado,
                FechaEntrega = request.FechaEntrega,
                LineaUsuario = request.LineaUsuario,
                PrecioUnitario = request.PrecioUnitario,
                CantidadPedida = request.CantidadPedida,
                CantidadAFacturar = request.CantidadAFacturar,
                CantidadFacturada = request.CantidadFacturada,
                CantidadReservada = request.CantidadReservada,
                CantidadBonificada = request.CantidadBonificada,
                CantidadCancelada = request.CantidadCancelada,
                TipoDescuento = request.TipoDescuento,
                MontoDescuento = request.MontoDescuento,
                PorcDescuento = request.PorcDescuento,
                Descripcion = request.Descripcion,
                Comentario = request.Comentario,
                PedidoLineaBonif = request.PedidoLineaBonif,
                UnidadDistribucionId = request.UnidadDistribucionId,
                FechaPrometida = request.FechaPrometida,
                LineaOrdenCompra = request.LineaOrdenCompra,
                CentroCuentaId = request.CentroCuentaId,
                RazonPerdida = request.RazonPerdida,
                TipoImpuesto1 = request.TipoImpuesto1,
                TipoTarifa1 = request.TipoTarifa1,
                TipoImpuesto2 = request.TipoImpuesto2,
                TipoTarifa2 = request.TipoTarifa2,
                PorcExoneracion = request.PorcExoneracion,
                MontoExoneracion = request.MontoExoneracion,
                PorcImpuesto1 = request.PorcImpuesto1,
                PorcImpuesto2 = request.PorcImpuesto2,
                EsOtroCargo = request.EsOtroCargo,
                EsCanastaBasica = request.EsCanastaBasica,
                PorcExoneracion2 = request.PorcExoneracion2,
                MontoExoneracion2 = request.MontoExoneracion2,
                PorcImp1Base = request.PorcImp1Base,
                PorcImp2Base = request.PorcImp2Base,
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