using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface ICuadreContaRepository
    {
        Task<ICollection<CuadreConta>> GetCollectionAsync(int page, int rows);
        Task<CuadreConta?> GetByIdAsync(int id);
        Task<int> CreateAsync(CuadreConta CuadreConta);
        Task<int> UpdateAsync(CuadreConta CuadreConta);
        Task<int> DeleteAsync(int id, string userId);
    }
}
