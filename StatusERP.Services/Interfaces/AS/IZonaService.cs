using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IZonaService
{
    Task<BaseResponseGeneric<ICollection<Zona>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<Zona>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoZona request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoZona request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}