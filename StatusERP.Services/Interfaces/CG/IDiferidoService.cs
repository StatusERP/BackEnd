using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface IDiferidoService
    {
        Task<BaseResponseGeneric<ICollection<Diferido>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<Diferido>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoDiferido request, string userId, string codDiferido);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDiferido request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}