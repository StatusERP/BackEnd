using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface ISaldoCuentaRepository
    {
        Task<ICollection<SaldoCuenta>> GetCollectionAsync(int page, int rows);
        Task<SaldoCuenta?> GetByIdAsync(int id);
        Task<int> CreateAsync(SaldoCuenta SaldoCuenta);
        Task<int> UpdateAsync(SaldoCuenta SaldoCuenta);
        Task<int> DeleteAsync(int id, string userId);
    }
}