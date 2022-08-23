using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface ITipoDocTributarioService
{
    Task<BaseResponseGeneric<ICollection<TipoDocTributario>>> GetAsync(string userId);
    Task<BaseResponseGeneric<TipoDocTributario>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoDocTributario request, string userId, string codTipoDT);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoDocTributario request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}