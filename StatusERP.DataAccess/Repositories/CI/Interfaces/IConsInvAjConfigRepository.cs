using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IConsInvAjConfigRepository
    {
        Task<ICollection<ConsInvAjConfig>> GetCollectionAsync();
        Task<ConsInvAjConfig?> GetByIdAsync(int id);
        Task<ConsInvAjConfig?> BuscarConsecAjusteAsync(int ConsecutivoId, int AjusteId);
        Task<int> CreateAsync(ConsInvAjConfig consInvAjConfig);
        Task<int> UpdateAsync(ConsInvAjConfig consInvAjConfig);
        Task<int> DeleteAsync(int id, string userId);
    }
}
