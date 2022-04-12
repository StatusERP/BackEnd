using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface ISeccionCuentaRepository
    {
        Task<ICollection<SeccionCuenta>> GetCollectionAsync(int page, int rows);
        Task<SeccionCuenta?> GetByIdAsync(int id);
        Task<SeccionCuenta?> BuscarCodSeccionCuentaAsync(string CodSeccionCuenta);
        Task<int> CreateAsync(SeccionCuenta SeccionCuenta);
        Task<int> UpdateAsync(SeccionCuenta SeccionCuenta);
        Task<int> DeleteAsync(int id, string userId);
    }
}