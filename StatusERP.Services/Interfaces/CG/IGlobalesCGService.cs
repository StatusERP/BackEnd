using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface IGlobalesCGService
    {
        Task<BaseResponseGeneric<ICollection<GlobalesCG>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<GlobalesCG>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoGlobalesCG request, string userId, string codGlobalesCG);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoGlobalesCG request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}