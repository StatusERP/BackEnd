using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Services.Interfaces.ERPADMIN;

public interface IAccionService
{
    Task<BaseResponseGeneric<ICollection<Accion>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<Accion>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoAccion request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoAccion request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}