using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface IDiarioDetRepository
    {
        Task<ICollection<DiarioDet>> GetCollectionAsync(int page, int rows);
        Task<DiarioDet?> GetByIdAsync(int id);
        Task<int> CreateAsync(DiarioDet DiarioDet);
        Task<int> UpdateAsync(DiarioDet DiarioDet);
        Task<int> DeleteAsync(int id, string userId);
    }
}