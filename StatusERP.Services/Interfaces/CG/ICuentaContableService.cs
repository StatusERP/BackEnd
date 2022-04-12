using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface ICuentaContableService
    {
        Task<BaseResponseGeneric<ICollection<CuentaContable>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<CuentaContable>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoCuentaContable request, string userId, string codCuentaContable);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCuentaContable request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
