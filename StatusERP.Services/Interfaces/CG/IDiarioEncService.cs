using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface IDiarioEncService
    {
        Task<BaseResponseGeneric<ICollection<DiarioEnc>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<DiarioEnc>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoDiarioEnc request, string userId, string codDiarioEnc);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDiarioEnc request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}