using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IConsecutivoInvRepository
    {
        Task<ICollection<ConsecutivoInv>> GetCollectionAsync(int page, int rows);
        Task<ConsecutivoInv?> GetByIdAsync(int id);
        Task<ConsecutivoInv?> BuscarCodConsecutivoInvAsync(string codConsecutivo);
        Task<int> CreateAsync(ConsecutivoInv consecutivoInv);
        Task<int> UpdateAsync(ConsecutivoInv consecutivoInv);
        Task<int> DeleteAsync(int id, string userId);
    }
}
