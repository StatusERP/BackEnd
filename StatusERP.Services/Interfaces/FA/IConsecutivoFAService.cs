using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.Services.Interfaces.FA;

public interface IConsecutivoFAService
{
    Task<BaseResponseGeneric<ICollection<ConsecutivoFA>>> GetAsync(string userId);
    Task<BaseResponseGeneric<ConsecutivoFA>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoConsecutivoFA request, string userId, string codConsecutivo);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsecutivoFA request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}
