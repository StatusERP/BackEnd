using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IAjusteSubSubTipoService
    {
        Task<BaseResponseGeneric<ICollection<AjusteSubSubTipo>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<AjusteSubSubTipo>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoAjusteSubSubTipo request, string userId, string ajusteConfig, string subSubTipo);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoAjusteSubSubTipo request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
