using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface ICuadreCGRepository
    {
        Task<ICollection<CuadreCG>> GetCollectionAsync(int page, int rows);
        Task<CuadreCG?> GetByIdAsync(int id);
        Task<CuadreCG?> BuscarCodCuadreCGAsync(int CodCuadreCG);
        Task<int> CreateAsync(CuadreCG CuadreCG);
        Task<int> UpdateAsync(CuadreCG CuadreCG);
        Task<int> DeleteAsync(int id, string userId);
    }
}