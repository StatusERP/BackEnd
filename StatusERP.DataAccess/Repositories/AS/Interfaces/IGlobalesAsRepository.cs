using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface IGlobalesAsRepository
{
    Task<ICollection<GlobalesAS>> GetCollectionAsync(int page, int rows); 
    Task<GlobalesAS?> GetByIdAsync(int id);
    Task<int> CreateAsync(GlobalesAS globalesAs);
    Task<int> UpdateAsync(GlobalesAS globalesAs);
    
}