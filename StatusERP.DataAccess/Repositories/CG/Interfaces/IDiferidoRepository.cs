using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface IDiferidoRepository
    {
        Task<ICollection<Diferido>> GetCollectionAsync(int page, int rows);
        Task<Diferido?> GetByIdAsync(int id);
        Task<Diferido?> BuscarCodDiferidoAsync(string codDiferido);
        Task<int> CreateAsync(Diferido Diferido);
        Task<int> UpdateAsync(Diferido Diferido);
        Task<int> DeleteAsync(int id, string userId);
    }
}