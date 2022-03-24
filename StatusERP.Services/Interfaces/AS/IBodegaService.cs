using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IBodegaService
{
    Task<BaseResponseGeneric<ICollection<Bodega>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<Bodega>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoBodega request,string userId,string codBodega);
    
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoBodega request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}