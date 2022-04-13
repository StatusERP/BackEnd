using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface ICuadreCGService
    {
        Task<BaseResponseGeneric<ICollection<CuadreCG>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<CuadreCG>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoCuadreCG request, string userId, string codCuadreCG);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCuadreCG request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
