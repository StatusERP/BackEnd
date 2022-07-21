using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface ILocalizacionesService
{
    
    Task<BaseResponseGeneric<ICollection<Localizacion>>> GetAsync( string userId);
    Task<BaseResponseGeneric<Localizacion>> GetByIdAsync(int id);
    Task<BaseResponseGeneric<ICollection< Localizacion>>> GetByIdBodegaAsync(int id,string userId);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoLocalizaciones request,string userId, string codLocalizacion, int BodegaId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoLocalizaciones request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}