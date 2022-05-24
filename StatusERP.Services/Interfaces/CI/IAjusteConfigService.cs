using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IAjusteConfigService
    {
        Task<BaseResponseGeneric<ICollection<AjusteConfig>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<AjusteConfig>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoAjusteConfig request, string userId, string codAjusteConfig);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoAjusteConfig request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
