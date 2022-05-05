using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IPaqueteInvService
    {
        Task<BaseResponseGeneric<ICollection<PaqueteInv>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<PaqueteInv>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoPaqueteInv request, string userId, string codPaqueteInv);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPaqueteInv request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}