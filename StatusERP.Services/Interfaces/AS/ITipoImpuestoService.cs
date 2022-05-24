using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface ITipoImpuestoService
{
    Task<BaseResponseGeneric<ICollection<TipoImpuesto>>> GetAsync(int page, int rows, string userId);

    Task<BaseResponseGeneric<TipoImpuesto>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoImpuesto request, string userId, string codTipoImpuesto);

    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoImpuesto request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}