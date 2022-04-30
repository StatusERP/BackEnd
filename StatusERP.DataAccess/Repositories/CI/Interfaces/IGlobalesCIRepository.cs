using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IGlobalesCIRepository
    {
        Task<ICollection<GlobalesCI>> GetCollectionAsync(int page, int rows);
        Task<GlobalesCI?> GetByIdAsync(int id);
        Task<int> CreateAsync(GlobalesCI globalesCI);
        Task<int> UpdateAsync(GlobalesCI globalesCI);
        Task<ICollection<GlobalesCI>> GetAllAsync();
    }
}
