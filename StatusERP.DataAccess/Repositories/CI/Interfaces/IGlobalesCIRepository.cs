using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IGlobalesCIRepository
    {
        Task<int> CreateAsync(GlobalesCI globalesCI);
        Task<int> UpdateAsync(GlobalesCI globalesCI);
        Task<ICollection<GlobalesCI>> GetAllAsync();
    }
}
