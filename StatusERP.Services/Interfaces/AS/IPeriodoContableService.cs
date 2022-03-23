using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IPeriodoContableService
{
    Task<BaseResponseGeneric<ICollection<PeriodoContable>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<PeriodoContable>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoPeridoContable request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPeridoContable request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}