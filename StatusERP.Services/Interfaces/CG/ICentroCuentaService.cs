using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface ICentroCuentaService
    {
        Task<BaseResponseGeneric<int>> CreateAsync(DtoCentroCuenta request, string userId, int CentroCostoId, int CuentaContableId);

        Task<BaseResponseGeneric<CentroCuenta>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<ICollection<CentroCuenta>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCentroCuenta request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

