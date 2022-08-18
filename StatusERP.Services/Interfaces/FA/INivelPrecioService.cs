using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.Services.Interfaces.FA;

public interface INivelPrecioService
{
    Task<BaseResponseGeneric<ICollection<NivelPrecio>>> GetAsync( int page, int rows, string userId);
    Task<BaseResponseGeneric<NivelPrecio>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoNivelPrecio request,string userId, string codNivelPrecio);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoNivelPrecio request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}