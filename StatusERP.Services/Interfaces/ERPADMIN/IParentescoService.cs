using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Services.Interfaces.ERPADMIN;

public interface IParentescoService
{
    Task<BaseResponseGeneric<ICollection<Parentesco>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<Parentesco>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoParentesco request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoParentesco request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}