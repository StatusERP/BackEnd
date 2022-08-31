using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.Services.Interfaces.FA;

public interface IArticuloPrecioService
{
    Task<BaseResponseGeneric<ICollection<ArticuloPrecio>>> GetAsync(string userId);
    Task<BaseResponseGeneric<ArticuloPrecio>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoArticuloPrecio request, string userId, int VersionNivelId, int ArticuloId, int VersionArticulo);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoArticuloPrecio request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}