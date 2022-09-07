using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.Services.Interfaces.FA;

public interface IPedidoDetService
{
    Task<BaseResponseGeneric<ICollection<PedidoDet>>> GetAsync( int page, int rows, string userId);
    Task<BaseResponseGeneric<PedidoDet>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoPedidoDet request,string userId, int pedidoEncId, Int16 pedidoLinea);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPedidoDet request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}