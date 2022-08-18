using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IDetalleDireccionService
{
    Task<BaseResponseGeneric<ICollection<DetalleDireccion>>> GetAsync(string userId);

    Task<BaseResponseGeneric<DetalleDireccion>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoDetalleDireccion request, string userId, int codDetalleDireccion);

    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDetalleDireccion request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}