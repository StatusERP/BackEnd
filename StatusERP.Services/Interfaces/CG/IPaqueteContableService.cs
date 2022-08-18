using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface IPaqueteContableService
    {
        Task<BaseResponseGeneric<ICollection<PaqueteContable>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<PaqueteContable>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoPaqueteContable request, string userId, string codPaquete);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPaqueteContable request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
