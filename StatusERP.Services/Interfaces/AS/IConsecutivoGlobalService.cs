using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IConsecutivoGlobalService
{
    Task<BaseResponseGeneric<ICollection<ConsecutivoGlobal>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<ConsecutivoGlobal>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoConsecutivoGlobal request,string userId, string codConsecutivoGlobal);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsecutivoGlobal request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}