using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IAjusteConfigRepository
    {
        Task<ICollection<AjusteConfig>> GetCollectionAsync(int page, int rows);
        Task<AjusteConfig?> GetByIdAsync(int id);
        Task<AjusteConfig?> BuscarCodAjusteConfigAsync(string codAjusteConfig);
        Task<int> CreateAsync(AjusteConfig ajusteConfig);
        Task<int> UpdateAsync(AjusteConfig ajusteConfig);
        Task<int> DeleteAsync(int id, string userId);
    }
}