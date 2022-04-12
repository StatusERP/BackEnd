using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface IDiarioDetService
    {
        Task<BaseResponseGeneric<ICollection<DiarioDet>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<DiarioDet>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoDiarioDet request, string userId, string codDiarioDet);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDiarioDet request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
