using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IConsInvAjConfigService
    {
        Task<BaseResponseGeneric<ICollection<ConsInvAjConfig>>> GetAsync(string userId);

        Task<BaseResponseGeneric<ConsInvAjConfig>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoConsInvAjConfig request, string userId, int ConsecutivoId, int AjusteId);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsInvAjConfig request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

