using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface IConsecutivoFARepository
{
    Task<ICollection<ConsecutivoFA>> GetCollectionAsync();
    Task<ConsecutivoFA?> GetByIdAsync(int id);
    Task<int> CreateAsync(ConsecutivoFA consecutivoFA);
    Task<int> UpdateAsync(ConsecutivoFA consecutivoFA);
    Task<int> DeleteAsync(int id, string userId);
    Task<ConsecutivoFA?> BuscarCodConsecutivoFAAsync(string codConsecutivo);
}