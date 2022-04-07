using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface ICuentaContableRepository
    {
        Task<ICollection<CuentaContable>> GetCollectionAsync(int page, int rows);
        Task<CuentaContable?> GetByIdAsync(int id);
        Task<CuentaContable?> BuscarCodCuentaContableAsync(string codCuentaContable);
        Task<int> CreateAsync(CuentaContable CuentaContable);
        Task<int> UpdateAsync(CuentaContable CuentaContable);
        Task<int> DeleteAsync(int id, string userId);
    }
}