using StatusERP.Dto.Request.CC;
using StatusERP.Dto.Response;
using StatusERP.Entities.CC.Tablas;

namespace StatusERP.Services.Interfaces.CC;

public interface ISubTipoDocCCService
{
    Task<BaseResponseGeneric<ICollection<SubTipoDocCC>>> GetAsync(string userId);
    Task<BaseResponseGeneric<SubTipoDocCC>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoSubTipoDocCC request, string userId, string tipo, int subTipo);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoSubTipoDocCC request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}