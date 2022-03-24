using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface IConsecutivoGlobalRepository
{
    Task<ICollection<ConsecutivoGlobal>> GetCollectionAsync(int page, int rows); 
    Task<ConsecutivoGlobal?> GetByIdAsync(int id);
    Task<int> CreateAsync(ConsecutivoGlobal consecutivoGlobal);
    Task<int> UpdateAsync(ConsecutivoGlobal consecutivoGlobal);
    Task<int> DeleteAsync(int id,string userId);
    Task<ConsecutivoGlobal?> BuscarCodConsecutivoGlobalesAsync(string codConsecutivoGlobales);
}