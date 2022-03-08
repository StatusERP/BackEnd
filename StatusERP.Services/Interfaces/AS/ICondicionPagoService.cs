using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface ICondicionPagoService
{
    Task<BaseResponseGeneric<ICollection<CondicionPago>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<CondicionPago>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoCondicionPago request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCondicionPago request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}