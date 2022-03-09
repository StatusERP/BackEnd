using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IDocTributarioService
{
    Task<BaseResponseGeneric<ICollection<DocTributario>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<DocTributario>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoDocTributario request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDocTributario request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}