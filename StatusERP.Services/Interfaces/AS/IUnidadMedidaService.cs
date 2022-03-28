using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IUnidadMedidaService
{
    Task<BaseResponseGeneric<ICollection<UnidadMedida>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<UnidadMedida>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoUnidadMedida request,string userId,string codUnidadMedida);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoUnidadMedida request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}