using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface ISeccionCuentaService
    {
        Task<BaseResponseGeneric<ICollection<SeccionCuenta>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<SeccionCuenta>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoSeccionCuenta request, string userId, string CodSeccionCuenta);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoSeccionCuenta request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}