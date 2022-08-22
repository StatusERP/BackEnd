using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.Services.Interfaces.FA;

public interface IVersionNivelPrecioService
{
    Task<BaseResponseGeneric<ICollection<VersionNivelPrecio>>> GetAsync(string userId);
    Task<BaseResponseGeneric<VersionNivelPrecio>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoVersionNivelPrecio request, string userId, int nivelPrecioId, int version);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoVersionNivelPrecio request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}