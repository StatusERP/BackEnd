using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface IMayorDetService
    {
        Task<BaseResponseGeneric<ICollection<MayorDet>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<MayorDet>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoMayorDet request, string userId, string codMayorDet);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMayorDet request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}