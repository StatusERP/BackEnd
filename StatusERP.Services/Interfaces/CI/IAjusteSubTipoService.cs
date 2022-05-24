using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IAjusteSubTipoService
    {
        Task<BaseResponseGeneric<ICollection<AjusteSubTipo>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<AjusteSubTipo>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoAjusteSubTipo request, string userId, string ajusteConfig, string subTipo);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoAjusteSubTipo request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}


