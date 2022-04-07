using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface IGlobalesCGRepository
    {
        Task<ICollection<GlobalesCG>> GetCollectionAsync(int page, int rows);
        Task<GlobalesCG?> GetByIdAsync(int id);
        Task<int> CreateAsync(GlobalesCG GlobalesCG);
        Task<int> UpdateAsync(GlobalesCG GlobalesCG);
        Task<int> DeleteAsync(int id, string userId);
    }
}