using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Services.Interfaces.ERPADMIN;

public interface IConjuntoService
{
    Task<BaseResponseGeneric<ICollection<Conjunto>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<Conjunto>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoConjunto request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConjunto request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}