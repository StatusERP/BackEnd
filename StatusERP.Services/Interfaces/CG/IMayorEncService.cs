using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface IMayorEncService
    {
        Task<BaseResponseGeneric<ICollection<MayorEnc>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<MayorEnc>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoMayorEnc request, string userId, string codMayorEnc);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMayorEnc request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
