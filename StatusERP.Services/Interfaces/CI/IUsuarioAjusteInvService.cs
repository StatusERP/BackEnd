using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IUsuarioAjusteInvService
    {
        Task<BaseResponseGeneric<ICollection<UsuarioAjusteInv>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<UsuarioAjusteInv>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoUsuarioAjusteInv request, string userId, string usuario, string ajusteConfig);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoUsuarioAjusteInv request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
