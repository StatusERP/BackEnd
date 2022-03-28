using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface ILocalizacionesService
{
    
    Task<BaseResponseGeneric<ICollection<Localizacion>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<Localizacion>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoLocalizaciones request,string userId, string codLocalizacion);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoLocalizaciones request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}