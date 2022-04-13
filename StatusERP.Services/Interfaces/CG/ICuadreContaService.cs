using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.Services.Interfaces.CG
{
    public interface ICuadreContaService
    {
        Task<BaseResponseGeneric<ICollection<CuadreConta>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<CuadreConta>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoCuadreConta request, string userId, string codCuadreConta);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCuadreConta request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);

    }
}

