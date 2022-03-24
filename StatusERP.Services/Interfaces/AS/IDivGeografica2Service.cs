using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IDivGeografica2Service
{
    Task<BaseResponseGeneric<ICollection<DivGeografica2>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<DivGeografica2>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoDivGeografica2 request,string userId, string codDivGeografica);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDivGeografica2 request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}