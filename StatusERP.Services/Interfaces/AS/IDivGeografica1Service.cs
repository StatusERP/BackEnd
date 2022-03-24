using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IDivGeografica1Service
{
    Task<BaseResponseGeneric<ICollection<DivGeografica1>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<DivGeografica1>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoDivGeografica1 request,string userId,string codDivGeografica);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDivGeografica1 request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}