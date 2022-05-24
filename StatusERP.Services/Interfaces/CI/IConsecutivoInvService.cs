using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IConsecutivoInvService
    {
        Task<BaseResponseGeneric<ICollection<ConsecutivoInv>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<ConsecutivoInv>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoConsecutivoInv request, string userId, string codConsecutivo);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsecutivoInv request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

