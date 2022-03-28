using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface ITipoCambioService
{
    Task<BaseResponseGeneric<ICollection<TipoCambio>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<TipoCambio>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoCambio request,string userId, string codTipoCambio);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoCambio request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}