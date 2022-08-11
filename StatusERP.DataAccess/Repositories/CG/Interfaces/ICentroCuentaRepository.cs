using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface ICentroCuentaRepository
    {
        Task<ICollection<CentroCuenta>> GetCollectionAsync(int page, int rows);
        Task<CentroCuenta?> GetByIdAsync(int id);
        Task<CentroCuenta?> BuscarCentroCuentaAsync(int centroCostoId, int CuentaContableId);
        Task<int> CreateAsync(CentroCuenta centroCuenta);
        Task<int> UpdateAsync(CentroCuenta centroCuenta);
        Task<int> DeleteAsync(int id, string userId);
    }
}