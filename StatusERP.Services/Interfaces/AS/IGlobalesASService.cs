using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IGlobalesASService
{
    Task<BaseResponseGeneric<ICollection<GlobalesAS>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<GlobalesAS>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoGlobalesAS request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoGlobalesAS request , string userId);
}