using StatusERP.Dto.Request.CB;
using StatusERP.Dto.Response;
using StatusERP.Entities.CB.Tablas;

namespace StatusERP.Services.Interfaces.CB;

public interface ISubTipoDocCBService
{
    Task<BaseResponseGeneric<ICollection<SubTipoDocCB>>> GetAsync(string userId);
    Task<BaseResponseGeneric<SubTipoDocCB>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoSubTipoDocCB request, string userId, string tipo, int subTipo);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoSubTipoDocCB request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}