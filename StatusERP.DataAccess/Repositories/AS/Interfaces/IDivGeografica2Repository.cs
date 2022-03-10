using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface IDivGeografica2Repository
{
    Task<ICollection<DivGeografica2>> GetCollectionAsync(int page, int rows); 
    Task<DivGeografica2?> GetByIdAsync(int id);
    Task<int> CreateAsync(DivGeografica2 divGeografica2);
    Task<int> UpdateAsync(DivGeografica2 divGeografica2);
    Task<int> DeleteAsync(int id,string userId);
}