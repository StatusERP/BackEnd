using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.Services.Interfaces.FA;

public interface IEscalaBonifService
{
    Task<BaseResponseGeneric<ICollection<EscalaBonif>>> GetAsync(string userId);
    Task<BaseResponseGeneric<EscalaBonif>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoEscalaBonif request, string userId, int versionNivelId, int articuloId, int numEscalaBonif, int versionBonif);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoEscalaBonif request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}