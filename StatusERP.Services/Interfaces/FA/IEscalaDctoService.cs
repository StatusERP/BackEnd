using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.Services.Interfaces.FA;

public interface IEscalaDctoService
{
    Task<BaseResponseGeneric<ICollection<EscalaDcto>>> GetAsync(string userId);
    Task<BaseResponseGeneric<EscalaDcto>> GetByIdAsync(int id);
    Task<BaseResponseGeneric<int>> CreateAsync(DtoEscalaDcto request, string userId, int versionNivelId, int articuloId, int numEscalaDcto, int versionDcto);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoEscalaDcto request, string userId);
    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}