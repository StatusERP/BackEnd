using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface INivelPrecioService
{
    Task<BaseResponseGeneric<ICollection<NivelPrecio>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<NivelPrecio>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoNivelprecio request,string userId, string codNivelPrecio);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoNivelprecio request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}