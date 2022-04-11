using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface ISaldoCuentaService
    {
        Task<BaseResponseGeneric<ICollection<SaldoCuenta>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<SaldoCuenta>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoSaldoCuenta request, string userId, string codSaldoCuenta);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoSaldoCuenta request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}