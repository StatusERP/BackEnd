using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface ICentroCuentaRepository
    {
        Task<ICollection<CentroCuenta>> GetCollectionAsync(int page, int rows);
        Task<CentroCuenta?> GetByIdAsync(int id);
        Task<CentroCuenta?> BuscarCodCentroCuentaAsync(string CodCentroCosto, string codCentroCuenta);
        Task<int> CreateAsync(CentroCuenta CentroCuenta);
        Task<int> UpdateAsync(CentroCuenta CentroCuenta);
        Task<int> DeleteAsync(int id, string userId);
    }
}