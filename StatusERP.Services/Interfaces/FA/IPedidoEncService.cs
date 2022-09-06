using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.Services.Interfaces.FA;

public interface IPedidoEncService
{
    Task<BaseResponseGeneric<ICollection<PedidoEnc>>> GetAsync( int page, int rows, string userId);
    Task<BaseResponseGeneric<PedidoEnc>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoPedidoEnc request,string userId, string Pedido);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPedidoEnc request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}